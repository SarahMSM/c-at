using System;
using System.Windows.Forms;

namespace chat
{
    public partial class MensagemCtr : UserControl
    {
        public MensagemCtr()
        {
            InitializeComponent();
        }

        public MensagemCtr(ItemMensagem m) : this()
        {
            BackColor = m.Minha ? Theme.Mostarda : Theme.Branco;
            txtTexto.BackColor = m.Minha ? Theme.MostardaClara : System.Drawing.Color.FromArgb(240, 240, 240);
            lblInfo.Text = m.Autor + ":\n" + m.DataHora.ToString("dd/MM/yyyy") + "\n" + m.DataHora.ToString("HH:mm:ss");
            txtTexto.Text = m.Texto;
        }
    }
}
