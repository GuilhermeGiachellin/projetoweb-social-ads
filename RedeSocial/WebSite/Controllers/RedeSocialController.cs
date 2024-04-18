using Microsoft.AspNetCore.Mvc;

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
