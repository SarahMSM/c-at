using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace chat.Data
{
    public partial class Contexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Conversa> Conversas { get; set; }
        public DbSet<UsuarioConversa> UsuarioConversas { get; set; }
        public DbSet<Mensagem> Mensagens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Host=projetoscti.com.br;" +
                                     "Database=cti_db;" +
                                     "Username= ra2557009;" +
                                     "Password= GwfHpbZoiyzaidjE;" +
                                     "Port=54432");
        }

    }

}
