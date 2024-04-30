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

        public List<AnuncioModel> getAnuncios()
        {
            List<AnuncioModel> listaAnuncios = new List<AnuncioModel>();
            listaAnuncios = MoqFactory.GerarListaAnuncio(2);
            return listaAnuncios;
        }
    }
}
