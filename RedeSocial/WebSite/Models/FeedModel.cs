namespace WebSite.Models
{
    public class FeedModel
    {
        public UsuarioModel Usuario { get; set; } = new UsuarioModel();        

        public required string Descricao { get; set; }

        public DateTime DataPublicacao { get; set; }

        public string UrlMidia { get; set; }

        public int Curtidas { get; set; }
 
    }
}
