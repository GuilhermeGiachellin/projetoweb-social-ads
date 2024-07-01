using System.Reflection.Metadata;
using WebSite.Backend.Model;

namespace WebSite.Models
{
    public class FeedModel
    {
		public Guid Id { get; set; }
		public UsuarioModel Usuario { get; set; } = new UsuarioModel();

		public List<string> ListaMidia { get; set; } = [];

		public required string Descricao { get; set; }

		public bool DidLike { get; set; }

		public DateTime DataPublicacao { get; set; }

		public int Curtidas { get; set; }		

		public List<ComentarioModel> ListaComentarios { get; set; } = [];

	}
}
