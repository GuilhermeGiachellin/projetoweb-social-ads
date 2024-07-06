using WebSite.Backend.Model;

namespace WebSite.Models
{
	public class ComentarioModel
	{
		public Guid Id;

		public UsuarioModel Usuario { get; set; } = new UsuarioModel();

		public DateTime DataComentario { get; set; }

		public required String Conteudo;

		public int Curtidas { get; set; }

		public bool IsUsuarioAutenticadoCurtiu { get; set; }

		public List<ComentarioModel> ListaComentarios { get; set; } = [];

	}
}

