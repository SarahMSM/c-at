using System;
using System.Linq;
using chat.Data;

namespace chat
{
    public class LoginPresenter
    {
        private readonly IFrmLogin view;

        public LoginPresenter(IFrmLogin view)
        {
            this.view = view;
            view.Entrar += (s, e) => Util.Seguro(view, Entrar);
        }

        private void Entrar()
        {
            string codigo = view.Codigo.Trim();
            string pin = view.Pin.Trim();

            if (codigo == "") { view.Erro("Informe o código."); return; }
            if (pin.Length != 4 || !pin.All(char.IsDigit))
            {
                view.Erro("O PIN deve ter exatamente 4 números.");
                return;
            }

            using var c = new Contexto();
            var u = c.Usuarios.FirstOrDefault(x => x.Codigo == codigo);

            if (u == null)
            {
                if (!view.Confirmar("O código informado não existe. Deseja criar o usuário?")) return;

                u = new Usuario { Codigo = codigo, Pin = BCrypt.Net.BCrypt.HashPassword(pin) };
                c.Usuarios.Add(u);
                c.SaveChanges();
            }
            else if (!BCrypt.Net.BCrypt.Verify(pin, u.Pin))
            {
                view.Erro("ERRO: PIN incorreto.");
                return;
            }

            Sessao.Usuario = u;
            view.Sucesso();
        }
    }
}
