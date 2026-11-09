using System;
using System.Windows.Forms;

namespace chat
{
    public partial class FrmLogin : Form, IFrmLogin
    {
        public string Codigo => txtCodigo.Text;
        public string Pin => txtPin.Text;
        public event EventHandler Entrar;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e) => Entrar?.Invoke(this, e);

        public void Sucesso()
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
