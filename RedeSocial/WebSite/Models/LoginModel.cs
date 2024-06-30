using System.ComponentModel.DataAnnotations;

namespace WebSite.Models
{
    public class LoginModel
    {

        [Required(ErrorMessage = "Email não informado. Por favor, verifique o campo!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha não informada. Por favor, verifique o campo!")]
        public string Senha { get; set; }

    }
}
