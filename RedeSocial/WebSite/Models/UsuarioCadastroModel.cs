﻿using System.ComponentModel.DataAnnotations;

namespace WebSite.Models
{
	public class UsuarioCadastroModel
	{
		public Guid Id { get; set; }
			
		[Required(ErrorMessage = "O nome não foi informado. Por favor, verifique!")]
		public string Nome { get; set; }

		[Required(ErrorMessage = "O sobrenome não foi informado. Por favor, verifique!")]
		public string Sobrenome { get; set; }

		[Required(ErrorMessage = "O e-mail não foi informado. Por favor, verifique!")]
		public string Email { get; set; }

		[Required(ErrorMessage = "A senha não foi informada. Por favor, verifique!")]
		public string Senha { get; set; }
		
		[Required(ErrorMessage = "A data comemorativa não foi informada. Por favor, verifique!")]
		public DateTime DataComemorativa { get; set; }
		public int Uf { get; set; }


	}	
}


