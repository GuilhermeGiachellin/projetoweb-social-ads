﻿using System.ComponentModel.DataAnnotations;

namespace WebSite.Models
{
    public class LoginModel
    {

        //[Required(ErrorMessage = "O e-mail não foi informado. Por favor, verifique!")]
        public string Email { get; set; }

       // [Required(ErrorMessage = "A senha não foi informada. Por favor, verifique!")]
        public string Senha { get; set; }

    }
}
