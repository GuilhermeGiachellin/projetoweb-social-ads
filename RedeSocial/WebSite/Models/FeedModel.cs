namespace WebSite.Models
{
    public class FeedModel
    {
        public UserModel Usuario { get; set; } = new UserModel();        

        public required string Descricao { get; set; }

        public DateTime DataPublicacao { get; set; }

        public string UrlMidia { get; set; }

        public int Curtidas { get; set; }
 
    }
}
