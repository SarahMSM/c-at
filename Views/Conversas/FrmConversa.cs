using System;
using System.Windows.Forms;

namespace chat
{
    public partial class FrmConversa : Form, IFrmConversa
    {
        public event EventHandler Enviar;
        public event EventHandler Atualizar;
        public event EventHandler Sair;

        public string Texto { get => txtTexto.Text; set => txtTexto.Text = value; }

        public FrmConversa()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e) => Enviar?.Invoke(this, e);
        private void btnSair_Click(object sender, EventArgs e) => Sair?.Invoke(this, e);

        // Verifica novas mensagens a cada 1 segundo
        private void tmrMensagens_Tick(object sender, EventArgs e) => Atualizar?.Invoke(this, e);

        public void DefinirTitulo(string titulo) => lblTitulo.Text = titulo;

        public void Adicionar(ItemMensagem msg)
        {
            var ctr = new MensagemCtr(msg);
            painel.Controls.Add(ctr);
            painel.ScrollControlIntoView(ctr);
        }

        public void Encerrado()
        {
            txtTexto.Enabled = false;
            btnEnviar.Enabled = false;
            btnSair.Enabled = false;
            txtTexto.Text = "Você saiu desta conversa.";
        }
    }
}
