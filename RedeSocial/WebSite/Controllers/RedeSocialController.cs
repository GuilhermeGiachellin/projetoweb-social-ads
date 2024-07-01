using Microsoft.AspNetCore.Mvc;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class RedeSocialController : Controller
    {
        public IActionResult Index()
        {
			  FeedController feedController = new FeedController();
			  AnuncioController anuncioController = new AnuncioController();
				

			  RedeSocialModel redeSocial = new RedeSocialModel();
			  /*redeSocial.Feed = feedController.getFeed();*/
			  redeSocial.Anuncio = anuncioController.getAnuncios();
			  ViewBag.Feed = redeSocial.Feed;
			  ViewBag.Anuncio = redeSocial.Anuncio;
			  return View();
			

		}

    }
}
