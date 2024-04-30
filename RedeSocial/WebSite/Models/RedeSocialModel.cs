namespace WebSite.Models
{
    public class RedeSocialModel
    {
        public UsuarioModel Usuario { get; set; }
        public List<AnuncioModel> Anuncio { get; set; }
        public List<FeedModel> Feed { get; set; }
    }
}
