namespace WebSite.Models
{
	public class UsuarioPerfilModel
	{
		public UserModel UsuarioAutenticado { get; set; } = new UserModel();
		public UserModel UsuarioPerfil { get; set; } = new UserModel();
		public List<FeedModel> ListaFeeds { get; set; } = [];
		public List<UserModel> ListaPrincipaisAmigos { get; set; } = [];
		public bool IsAmigo { get; set; }
	}
}
