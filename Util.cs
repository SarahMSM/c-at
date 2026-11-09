using System;

namespace chat
{
    public static class Util
    {
        // Executa uma ação mostrando qualquer erro (ex.: banco fora do ar) via view
        public static void Seguro(IViewBase v, Action acao)
        {
            try { acao(); }
            catch (Exception ex)
            {
                v.Erro("Erro: " + (ex.InnerException?.Message ?? ex.Message));
            }
        }
    }
}
