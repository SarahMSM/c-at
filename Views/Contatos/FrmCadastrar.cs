using System;
using System.Windows.Forms;

namespace chat
{
    public partial class FrmCadastrar : Form, IFrmCadastrar
    {
        public event EventHandler Salvar;
        public string Codigo => txtCodigo.Text;
        public string Nome => txtNome.Text;

        public FrmCadastrar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e) => Salvar?.Invoke(this, e);
        private void btnCancelar_Click(object sender, EventArgs e) => Close();

        public void Fechar()
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
