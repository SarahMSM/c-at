using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace chat
{
    public partial class FrmListar : Form, IFrmListarContatos
    {
        public event EventHandler Carregar;
        public event Action<int> Remover;
        public string Filtro => txtNome.Text.Trim();

        public FrmListar()
        {
            InitializeComponent();
        }

        private void FrmListar_Load(object sender, EventArgs e) => Carregar?.Invoke(this, e);
        private void btnFiltrar_Click(object sender, EventArgs e) => Carregar?.Invoke(this, e);

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using var f = new FrmCadastrar();
            new CadastrarContatoPresenter(f);
            f.ShowDialog(this);
            Carregar?.Invoke(this, EventArgs.Empty);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var item = Selecionado();
            if (item == null) return;
            using var f = new FrmEditar();
            new EditarContatoPresenter(f, item.Id);
            f.ShowDialog(this);
            Carregar?.Invoke(this, EventArgs.Empty);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var item = Selecionado();
            if (item != null) Remover?.Invoke(item.Id);
        }

        private ItemContato Selecionado()
        {
            if (lista.SelectedItems.Count == 0)
            {
                ((IViewBase)this).Info("Selecione um contato na lista.");
                return null;
            }
            return (ItemContato)lista.SelectedItems[0].Tag;
        }

        public void Mostrar(List<ItemContato> itens) => Theme.Preencher(lista, itens);
    }
}
