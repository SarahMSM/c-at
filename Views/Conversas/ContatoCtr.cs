using System;
using System.Windows.Forms;

namespace chat
{
    public partial class ContatoCtr : UserControl
    {
        public ItemContato Item { get; private set; }
        public event Action<ContatoCtr> Apagar;

        public ContatoCtr()
        {
            InitializeComponent();
        }

        public ContatoCtr(ItemContato item) : this()
        {
            Item = item;
            lblNome.Text = item.Nome;
        }

        private void btnApagar_Click(object sender, EventArgs e) => Apagar?.Invoke(this);
    }
}
