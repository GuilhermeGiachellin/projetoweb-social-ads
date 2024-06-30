namespace WebSite.Models
{
    public class RedeSocialModel
    {
        public UserModel Usuario { get; set; }
  //      public UsuarioCadastroModel UsuarioCadastro { get; set; }
  //      public UsuarioPerfilModel UsuarioPerfil { get; set; }
   //     public List<UsuarioAmigos> usuarioAmigos { get; set; }
        public List<AnuncioModel> Anuncio { get; set; }
        public List<FeedModel> Feed { get; set; }
		public UsuarioPublicacaoModel Publicacao { get; set; }

	}
}
