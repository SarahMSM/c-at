using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace chat
{
    public partial class FrmBuscarContato : Form, IFrmBuscarContato
    {
        public event EventHandler Carregar;
        public string Filtro => txtNome.Text.Trim();
        public List<ItemContato> Selecionados =>
            lista.SelectedItems.Cast<ListViewItem>().Select(i => (ItemContato)i.Tag).ToList();

        public FrmBuscarContato()
        {
            InitializeComponent();
        }

        private void FrmBuscarContato_Load(object sender, EventArgs e) => Carregar?.Invoke(this, e);
        private void btnFiltrar_Click(object sender, EventArgs e) => Carregar?.Invoke(this, e);

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (lista.SelectedItems.Count == 0)
            {
                ((IViewBase)this).Info("Selecione ao menos um contato.");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        public void Mostrar(List<ItemContato> itens) => Theme.Preencher(lista, itens);
    }
}
