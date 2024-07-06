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
			return View();
		}	
		
    }
}
