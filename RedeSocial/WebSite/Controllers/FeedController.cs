using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebSite.Factory;
using WebSite.Models;

namespace WebSite.Controllers
{
	public class FeedController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public List<FeedModel> getFeed()
		{
            List <FeedModel> listaFeed = new List<FeedModel>();

			listaFeed = MoqFactory.GerarListaFeed(5);

            return listaFeed;
		}
	}
}
