using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace chat
{
    // Métodos comuns de mensagem (implementação padrão: MessageBox)
    public interface IViewBase
    {
        bool Confirmar(string msg) =>
            MessageBox.Show(msg, "C#at", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        void Info(string msg) =>
            MessageBox.Show(msg, "C#at", MessageBoxButtons.OK, MessageBoxIcon.Information);
        void Erro(string msg) =>
            MessageBox.Show(msg, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public interface IFrmLogin : IViewBase
    {
        string Codigo { get; }
        string Pin { get; }
        event EventHandler Entrar;
        void Sucesso();
    }

    public interface IFrmListas : IViewBase
    {
        event EventHandler Atualizar;
        event Action<int> Apagar;
        void Mostrar(List<ItemConversa> itens);
    }

    public interface IFrmListarContatos : IViewBase
    {
        string Filtro { get; }
        event EventHandler Carregar;
        event Action<int> Remover;
        void Mostrar(List<ItemContato> itens);
    }

    public interface IFrmCadastrar : IViewBase
    {
        string Codigo { get; }
        string Nome { get; }
        event EventHandler Salvar;
        void Fechar();
    }

    public interface IFrmEditar : IViewBase
    {
        string Nome { get; }
        event EventHandler Salvar;
        void Preencher(string nome, string codigo);
        void Fechar();
    }

    public interface IFrmBuscarContato : IViewBase
    {
        string Filtro { get; }
        event EventHandler Carregar;
        void Mostrar(List<ItemContato> itens);
    }

    public interface IFrmCriar : IViewBase
    {
        string Titulo { get; }
        List<ItemContato> Contatos { get; }
        event EventHandler Criar;
        void Concluir();
    }

    public interface IFrmConversa : IViewBase
    {
        string Texto { get; set; }
        event EventHandler Enviar;
        event EventHandler Atualizar;
        event EventHandler Sair;
        void DefinirTitulo(string titulo);
        void Adicionar(ItemMensagem msg);
        void Encerrado();
    }
}
