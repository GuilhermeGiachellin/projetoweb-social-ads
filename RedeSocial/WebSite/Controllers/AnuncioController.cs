using Microsoft.AspNetCore.Mvc;
using WebSite.Factory;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class AnuncioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
		public IActionResult AnuncioCadastro()
		{
            AnuncioModel anuncio = new AnuncioModel();
            anuncio.Id = "1";
            anuncio.URLImagem = "https://static.escolakids.uol.com.br/2023/09/ilustracao-de-um-megafone-apontado-para-um-balao-de-grito-com-o-escrito-anuncio-publicitario.jpg";
            anuncio.Texto = "Anuncio 1";
            anuncio.Link = "link";


			return View(anuncio);
		}
		
		public List<AnuncioModel> getAnuncios()
        {
            List<AnuncioModel> listaAnuncios = new List<AnuncioModel>();
            listaAnuncios = MoqFactory.GerarListaAnuncio(2);
            return listaAnuncios;
        }
    }
}
