using System.ComponentModel.DataAnnotations;

namespace WebSite.Integracao.Responce
{
	public class ViaUsuarioResponse
	{

		public string Nome { get; set; }

		public string Sobrenome { get; set; }

		public string Email { get; set; }

		public string Senha { get; set; }

		public string SenhaRepetida { get; set; }

		public DateTime DataComemorativa { get; set; }

	}
}
