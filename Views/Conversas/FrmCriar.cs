using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace chat
{
    public partial class FrmCriar : Form, IFrmCriar
    {
        public event EventHandler Criar;
        public string Titulo => txtNome.Text;
        public List<ItemContato> Contatos =>
            painel.Controls.OfType<ContatoCtr>().Select(c => c.Item).ToList();

        public FrmCriar()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var f = new FrmBuscarContato();
            new BuscarContatoPresenter(f);
            if (f.ShowDialog(this) != DialogResult.OK) return;

            foreach (var item in f.Selecionados)
            {
                if (Contatos.Any(x => x.ContatoId == item.ContatoId)) continue;
                var ctr = new ContatoCtr(item);
                ctr.Apagar += c => { painel.Controls.Remove(c); c.Dispose(); };
                painel.Controls.Add(ctr);
            }
        }

        private void btnCriar_Click(object sender, EventArgs e) => Criar?.Invoke(this, e);

        public void Concluir()
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
