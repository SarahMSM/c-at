using System;
using System.Collections.Generic;
using System.Linq;
using chat.Data;

namespace chat
{
    // Conversas/FrmListas
    public class ListasPresenter
    {
        private readonly IFrmListas view;

        public ListasPresenter(IFrmListas view)
        {
            this.view = view;
            view.Atualizar += (s, e) => Util.Seguro(view, Carregar);
            view.Apagar += id => Util.Seguro(view, () => Apagar(id));
            Util.Seguro(view, Carregar);
        }

        public void Carregar()
        {
            int me = Sessao.Usuario.Id;
            using var c = new Contexto();

            var minhas = c.UsuarioConversas
                .Where(u => u.UsuarioId == me)
                .Select(u => new
                {
                    u.ConversaId,
                    u.SaiuEm,
                    u.Conversa.Titulo,
                    u.Conversa.CriadoEm
                }).ToList();

            var ids = minhas.Select(m => m.ConversaId).ToList();

            var ultimas = c.Mensagens
                .Where(m => ids.Contains(m.UsuarioConversa.ConversaId))
                .GroupBy(m => m.UsuarioConversa.ConversaId)
                .Select(g => new { Id = g.Key, Data = g.Max(m => m.DataHora) })
                .ToDictionary(x => x.Id, x => x.Data);

            var participantes = c.UsuarioConversas
                .Where(u => ids.Contains(u.ConversaId) && u.UsuarioId != me)
                .Select(u => new { u.ConversaId, u.UsuarioId })
                .ToList();

            var nomes = c.Contatos.Where(x => x.UsuarioId == me)
                .Select(x => new { x.ContatoId, x.Nome }).ToList()
                .GroupBy(x => x.ContatoId).ToDictionary(g => g.Key, g => g.First().Nome);

            var outrosIds = participantes.Select(p => p.UsuarioId).Distinct().ToList();
            var codigos = c.Usuarios.Where(u => outrosIds.Contains(u.Id))
                .ToDictionary(u => u.Id, u => u.Codigo);

            var itens = minhas.Select(m =>
            {
                string titulo = m.Titulo;
                if (string.IsNullOrWhiteSpace(titulo))
                {
                    var outros = participantes.Where(p => p.ConversaId == m.ConversaId)
                        .Select(p => nomes.ContainsKey(p.UsuarioId) ? nomes[p.UsuarioId]
                                   : codigos.ContainsKey(p.UsuarioId) ? codigos[p.UsuarioId] : "?");
                    titulo = string.Join(", ", outros);
                    if (titulo == "") titulo = "(só você)";
                }
                return new ItemConversa
                {
                    Id = m.ConversaId,
                    Titulo = titulo,
                    Saiu = m.SaiuEm != null,
                    Ultima = ultimas.ContainsKey(m.ConversaId) ? ultimas[m.ConversaId] : m.CriadoEm
                };
            })
            .OrderByDescending(i => i.Ultima)
            .ToList();

            view.Mostrar(itens);
        }

        // Criador: apaga a conversa inteira. Participante: apenas sai dela.
        private void Apagar(int conversaId)
        {
            int me = Sessao.Usuario.Id;
            using var c = new Contexto();
            var conversa = c.Conversas.Find(conversaId);
            if (conversa == null) { Carregar(); return; }

            if (conversa.CriadoPor == me)
            {
                if (!view.Confirmar("Você criou esta conversa. Apagar para TODOS os participantes?")) return;

                var vinculos = c.UsuarioConversas.Where(u => u.ConversaId == conversaId).ToList();
                var vincIds = vinculos.Select(v => v.Id).ToList();
                c.Mensagens.RemoveRange(c.Mensagens.Where(m => vincIds.Contains(m.UsuConvId)));
                c.UsuarioConversas.RemoveRange(vinculos);
                c.Conversas.Remove(conversa);
            }
            else
            {
                var uc = c.UsuarioConversas.First(u => u.ConversaId == conversaId && u.UsuarioId == me);
                if (uc.SaiuEm != null) { view.Info("Você já saiu desta conversa."); return; }
                if (!view.Confirmar("Sair desta conversa?")) return;
                uc.SaiuEm = DateTime.Now;
            }

            c.SaveChanges();
            Carregar();
        }
    }

    // Conversas/FrmCriar
    public class CriarConversaPresenter
    {
        private readonly IFrmCriar view;

        public CriarConversaPresenter(IFrmCriar view)
        {
            this.view = view;
            view.Criar += (s, e) => Util.Seguro(view, Criar);
        }

        private void Criar()
        {
            var contatos = view.Contatos;
            string titulo = view.Titulo.Trim();

            if (contatos.Count == 0) { view.Erro("Adicione ao menos um contato."); return; }
            if (contatos.Count > 1 && titulo == "") { view.Erro("Dê um nome ao grupo."); return; }

            int me = Sessao.Usuario.Id;
            using var c = new Contexto();

            var conversa = new Conversa { Titulo = titulo, CriadoPor = me, CriadoEm = DateTime.Now };
            c.Conversas.Add(conversa);
            c.SaveChanges();

            var participantes = contatos.Select(x => x.ContatoId).Append(me).Distinct();
            foreach (int uid in participantes)
                c.UsuarioConversas.Add(new UsuarioConversa { UsuarioId = uid, ConversaId = conversa.Id });
            c.SaveChanges();

            view.Concluir();
        }
    }

    // Conversas/FrmConversa
    public class ConversaPresenter
    {
        private readonly IFrmConversa view;
        private readonly int conversaId;
        private int meuVinculo;
        private int ultimoId = 0;
        private bool saiu;
        private Dictionary<int, string> nomes = new Dictionary<int, string>();

        public ConversaPresenter(IFrmConversa view, int conversaId, string titulo)
        {
            this.view = view;
            this.conversaId = conversaId;

            view.Enviar += (s, e) => Util.Seguro(view, Enviar);
            view.Atualizar += (s, e) => Util.Seguro(view, Buscar);
            view.Sair += (s, e) => Util.Seguro(view, Sair);

            view.DefinirTitulo(titulo);
            Util.Seguro(view, Iniciar);
        }

        private void Iniciar()
        {
            int me = Sessao.Usuario.Id;
            using var c = new Contexto();
            var uc = c.UsuarioConversas.First(u => u.ConversaId == conversaId && u.UsuarioId == me);
            meuVinculo = uc.Id;
            saiu = uc.SaiuEm != null;

            nomes = c.Contatos.Where(x => x.UsuarioId == me)
                .Select(x => new { x.ContatoId, x.Nome }).ToList()
                .GroupBy(x => x.ContatoId).ToDictionary(g => g.Key, g => g.First().Nome);

            if (saiu) view.Encerrado();
            Buscar();
        }

        private string NomeDe(Contexto c, int usuarioId)
        {
            if (!nomes.ContainsKey(usuarioId))
                nomes[usuarioId] = c.Usuarios.Where(u => u.Id == usuarioId)
                                    .Select(u => u.Codigo).FirstOrDefault() ?? "?";
            return nomes[usuarioId];
        }

        private void Buscar()
        {
            int me = Sessao.Usuario.Id;
            using var c = new Contexto();
            var novas = c.Mensagens
                .Where(m => m.UsuarioConversa.ConversaId == conversaId && m.Id > ultimoId)
                .OrderBy(m => m.Id)
                .Select(m => new { m.Id, m.Texto, m.DataHora, m.UsuarioConversa.UsuarioId })
                .ToList();

            foreach (var m in novas)
            {
                view.Adicionar(new ItemMensagem
                {
                    Id = m.Id,
                    Texto = m.Texto,
                    DataHora = m.DataHora,
                    Minha = m.UsuarioId == me,
                    Autor = m.UsuarioId == me ? "Você" : NomeDe(c, m.UsuarioId)
                });
                ultimoId = m.Id;
            }
        }

        private void Enviar()
        {
            if (saiu) { view.Erro("Você saiu desta conversa e não pode mais enviar mensagens."); return; }
            string texto = (view.Texto ?? "").Trim();
            if (texto == "") return;

            using (var c = new Contexto())
            {
                c.Mensagens.Add(new Mensagem { UsuConvId = meuVinculo, Texto = texto, DataHora = DateTime.Now });
                c.SaveChanges();
            }
            view.Texto = "";
            Buscar();
        }

        private void Sair()
        {
            if (saiu) return;
            if (!view.Confirmar("Deseja realmente sair desta conversa?")) return;

            using var c = new Contexto();
            var uc = c.UsuarioConversas.Find(meuVinculo);
            uc.SaiuEm = DateTime.Now;
            c.SaveChanges();

            saiu = true;
            view.Encerrado();
        }
    }
}
