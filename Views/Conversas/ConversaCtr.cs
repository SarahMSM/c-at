using System;
using System.Windows.Forms;

namespace chat
{
    public partial class ConversaCtr : UserControl
    {
        public ItemConversa Item { get; private set; }
        public event Action<int> Ver;
        public event Action<int> Apagar;

        public ConversaCtr()
        {
            InitializeComponent();
        }

        public ConversaCtr(ItemConversa item) : this()
        {
            Item = item;
            lblTitulo.Text = item.Titulo + (item.Saiu ? "  (saiu)" : "");
        }

        private void btnVer_Click(object sender, EventArgs e) => Ver?.Invoke(Item.Id);
        private void btnApagar_Click(object sender, EventArgs e) => Apagar?.Invoke(Item.Id);
    }
}
