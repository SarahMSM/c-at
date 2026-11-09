using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace chat
{
    // Paleta: vinho, verde escuro, mostarda, preto e branco
    public static class Theme
    {
        public static readonly Color Vinho = Color.FromArgb(107, 17, 40);
        public static readonly Color VinhoEscuro = Color.FromArgb(74, 11, 27);
        public static readonly Color Verde = Color.FromArgb(30, 77, 43);
        public static readonly Color Mostarda = Color.FromArgb(212, 160, 23);
        public static readonly Color MostardaClara = Color.FromArgb(243, 223, 162);
        public static readonly Color Preto = Color.FromArgb(18, 18, 18);
        public static readonly Color Branco = Color.White;

        public static void Preencher(ListView l, List<ItemContato> itens)
        {
            l.Items.Clear();
            foreach (var i in itens)
            {
                var it = new ListViewItem(i.Nome) { Tag = i };
                it.SubItems.Add(i.Codigo);
                l.Items.Add(it);
            }
        }
    }
}
