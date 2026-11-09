using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace chat
{
    public partial class FrmListas : Form, IFrmListas
    {
        public event EventHandler Atualizar;
        public event Action<int> Apagar;

        public FrmListas()
        {
            InitializeComponent();
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {
            using var f = new FrmListar();
            new ContatosPresenter(f);
            f.ShowDialog(this);
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            using var f = new FrmCriar();
            new CriarConversaPresenter(f);
            if (f.ShowDialog(this) == DialogResult.OK) Atualizar?.Invoke(this, EventArgs.Empty);
        }

        // Busca novas conversas/mensagens a cada 30 segundos
        private void tmrAtualizar_Tick(object sender, EventArgs e) => Atualizar?.Invoke(this, EventArgs.Empty);

        public void Mostrar(List<ItemConversa> itens)
        {
            painel.SuspendLayout();
            foreach (var c in painel.Controls.Cast<Control>().ToList())
            {
                painel.Controls.Remove(c);
                c.Dispose();
            }

            foreach (var item in itens)
            {
                var ctr = new ConversaCtr(item);
                ctr.Ver += id => AbrirConversa(item);
                ctr.Apagar += id => Apagar?.Invoke(id);
                painel.Controls.Add(ctr);
            }
            painel.ResumeLayout();
        }

        private void AbrirConversa(ItemConversa item)
        {
            using var f = new FrmConversa();
            new ConversaPresenter(f, item.Id, item.Titulo);
            f.ShowDialog(this);
            Atualizar?.Invoke(this, EventArgs.Empty);
        }
    }
}
