using System;
using System.Windows.Forms;

namespace chat
{
    public partial class FrmEditar : Form, IFrmEditar
    {
        public event EventHandler Salvar;
        public string Nome => txtNome.Text;

        public FrmEditar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e) => Salvar?.Invoke(this, e);
        private void btnCancelar_Click(object sender, EventArgs e) => Close();

        public void Preencher(string nome, string codigo)
        {
            txtNome.Text = nome;
            txtCodigo.Text = codigo;
        }

        public void Fechar()
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }
    }
}
