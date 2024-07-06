using Microsoft.AspNetCore.Mvc;
using WebSite.Models;

namespace WebSite.Controllers
{
	public class RedeSocialController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

	}
}
