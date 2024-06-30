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

        public static UsuarioCadastroModel ToUsuarioCadastroModel(UsuarioModel usuario)
        {
            return new()
            {
                Nome = usuario.Nome,
                Sobrenome = usuario.Sobrenome,
                Email = usuario.Email,
                DataComemorativa = usuario.DataComemorativa
            };
        }
    }
}
