using System;
using System.Collections.Generic;
using System.Linq;
using chat.Data;
using Microsoft.EntityFrameworkCore;

namespace chat
{
    public static class ContatoRepo
    {
        public static List<ItemContato> Listar(string filtro)
        {
            int me = Sessao.Usuario.Id;
            using var c = new Contexto();
            var q = c.Contatos.Where(x => x.UsuarioId == me);
            if (!string.IsNullOrWhiteSpace(filtro))
                q = q.Where(x => EF.Functions.ILike(x.Nome, "%" + filtro.Trim() + "%"));

            return q.OrderBy(x => x.Nome)
                    .Select(x => new ItemContato
                    {
                        Id = x.Id,
                        ContatoId = x.ContatoId,
                        Nome = x.Nome,
                        Codigo = x.ContatoUsuario.Codigo
                    })
                    .ToList();
        }
    }

    // Contatos/FrmListar
    public class ContatosPresenter
    {
        private readonly IFrmListarContatos view;

        public ContatosPresenter(IFrmListarContatos view)
        {
            this.view = view;
            view.Carregar += (s, e) => Util.Seguro(view, Carregar);
            view.Remover += id => Util.Seguro(view, () => Remover(id));
        }

        private void Carregar() => view.Mostrar(ContatoRepo.Listar(view.Filtro));

        private void Remover(int id)
        {
            if (!view.Confirmar("Remover este contato?")) return;
            using var c = new Contexto();
            var ct = c.Contatos.Find(id);
            if (ct != null)
            {
                c.Contatos.Remove(ct);
                c.SaveChanges();
            }
            Carregar();
        }
    }

    // Contatos/FrmCadastrar
    public class CadastrarContatoPresenter
    {
        private readonly IFrmCadastrar view;

        public CadastrarContatoPresenter(IFrmCadastrar view)
        {
            this.view = view;
            view.Salvar += (s, e) => Util.Seguro(view, Salvar);
        }

        private void Salvar()
        {
            string codigo = view.Codigo.Trim();
            string nome = view.Nome.Trim();
            if (codigo == "" || nome == "") { view.Erro("Preencha o código e o nome."); return; }

            int me = Sessao.Usuario.Id;
            using var c = new Contexto();
            var alvo = c.Usuarios.FirstOrDefault(u => u.Codigo == codigo);

            if (alvo == null) { view.Erro("Nenhum usuário encontrado com esse código."); return; }
            if (alvo.Id == me) { view.Erro("Você não pode adicionar a si mesmo."); return; }
            if (c.Contatos.Any(x => x.UsuarioId == me && x.ContatoId == alvo.Id))
            {
                view.Erro("Esse usuário já está nos seus contatos.");
                return;
            }

            c.Contatos.Add(new Contato { ContatoId = alvo.Id, Nome = nome, UsuarioId = me });
            c.SaveChanges();
            view.Fechar();
        }
    }

    // Contatos/FrmEditar
    public class EditarContatoPresenter
    {
        private readonly IFrmEditar view;
        private readonly int contatoId;

        public EditarContatoPresenter(IFrmEditar view, int contatoId)
        {
            this.view = view;
            this.contatoId = contatoId;
            view.Salvar += (s, e) => Util.Seguro(view, Salvar);
            Util.Seguro(view, Carregar);
        }

        private void Carregar()
        {
            using var c = new Contexto();
            var ct = c.Contatos.Include(x => x.ContatoUsuario).First(x => x.Id == contatoId);
            view.Preencher(ct.Nome, ct.ContatoUsuario.Codigo);
        }

        private void Salvar()
        {
            string nome = view.Nome.Trim();
            if (nome == "") { view.Erro("Informe o nome."); return; }

            using var c = new Contexto();
            var ct = c.Contatos.First(x => x.Id == contatoId);
            ct.Nome = nome;
            c.SaveChanges();
            view.Fechar();
        }
    }

    // Conversas/FrmBuscarContato
    public class BuscarContatoPresenter
    {
        private readonly IFrmBuscarContato view;

        public BuscarContatoPresenter(IFrmBuscarContato view)
        {
            this.view = view;
            view.Carregar += (s, e) => Util.Seguro(view, () => view.Mostrar(ContatoRepo.Listar(view.Filtro)));
        }
    }
}
