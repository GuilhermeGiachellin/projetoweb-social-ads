using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

		// Login
		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Login(string nome, string senha)
		{
			if (nome == "Guilherme" && senha == "123456")
			{
				return RedirectToAction("Index", "RedeSocial");
			}
			else
			{
				ViewBag.MensagemErro = "Nome de usuário ou senha incorretos.";
				return View();
			}
		}

		//Cadastrar
		public IActionResult Cadastrar()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Cadastrar(UsuarioModel usuario)
		{
			if (usuario.Senha == "" || usuario.Nome == "") {
				ViewBag.MensagemErro = "Preencha os campos corretamente";
				return View();
			}
			if (!ModelState.IsValid)
			{
				ViewBag.MensagemErro = "Preencha os campos corretamente";
				return View();
			} else
			{
				return RedirectToAction("Index", "RedeSocial");
			}
		}
	}
}

