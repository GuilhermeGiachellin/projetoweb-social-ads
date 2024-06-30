using WebSite.Backend.Model;
using WebSite.Models;

namespace WebSite.Backend.Adapter
{
    public class UsuarioAdapter
    {
        public static UsuarioLogin ToUsuarioLoginModel(LoginModel login)
        {
            return new UsuarioLogin()
            {
                Email = login.Email,
                Senha = login.Senha,
            };
        }
    }
}
