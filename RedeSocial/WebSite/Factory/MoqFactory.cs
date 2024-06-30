using WebSite.Models;

namespace WebSite.Factory
{
    public class MoqFactory
    {
        public static List<FeedModel> GerarListaFeed(int quantia)
        {
            List<FeedModel> feeds = new List<FeedModel>();

            for (int i = 0; i < quantia; i++)
            {
                feeds.Add(new FeedModel()
                { 
                    Usuario = new UserModel
                    {
                        Nome = "Fulano" + i,
                        Sobrenome = "Silva" + i,
                        Senha = "123",
                        DataComemorativa = DateTime.Now,
                    },
                    Descricao = "Descriacao" + i,
                    DataPublicacao = DateTime.Now,
                    UrlMidia = "https://cdn.pixabay.com/photo/2014/12/16/22/25/sunset-570881_960_720.jpg",
                    Curtidas = i,
                });
            }
            return feeds;
        }

        public static List<AnuncioModel> GerarListaAnuncio(int quantia)
        {
            List<AnuncioModel> feeds = new List<AnuncioModel>();

            for (int i = 0; i < quantia; i++)
            {
                feeds.Add(new AnuncioModel()
                {
                   URLImagem = "https://madeinsingaporelah.com/wp-content/uploads/2022/01/burger-king-promotion-2022.jpg",
                   Texto = "Anuncio Restaurante" + i,
                   Link = "https://www.burgerking.com.br/"
                });
            }
            return feeds;
        }
    }
}
