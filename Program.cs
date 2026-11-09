using System;
using System.Windows.Forms;

namespace chat
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Permite gravar DateTime.Now em colunas "timestamp" sem erro de Kind
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            ApplicationConfiguration.Initialize();

            using (var login = new FrmLogin())
            {
                new LoginPresenter(login);
                if (login.ShowDialog() != DialogResult.OK) return;
            }

            var principal = new FrmListas();
            new ListasPresenter(principal);
            Application.Run(principal);
        }
    }
}
