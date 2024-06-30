using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebSite.Factory;
using WebSite.Models;


namespace WebSite.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {			
				UsuarioPublicacaoModel publicacao = new UsuarioPublicacaoModel();

				publicacao.Id = 1;
				publicacao.Usuario = "Andre";
				publicacao.Descricao = "Mensagem";
				publicacao.DataPublicacao = "06/06/24";
				publicacao.UrlsMidia = "https://www.msn.com/pt-br/viagem/noticias/os-pa%C3%ADses-com-as-pessoas-mais-bonitas/ss-BB1oAuaW?ocid=msedgntp&pc=DCTS&cvid=c759fca34c6e456cbd30226970b2dafd&ei=18";

				return View(publicacao);
			
        }

		// Login
		public IActionResult Login()
		{
			return View();
		}

		// Login
		public IActionResult UsuarioCadastro()
		{
			return View();
		}

		public IActionResult UsuarioPublicacao()
		{
			return View();
		}
        public IActionResult UsuarioPerfil()
        {
            return View();
        }
		public IActionResult UsuarioAmigos()
		{
            UsuarioAmigos amigos = new UsuarioAmigos();
			amigos.Id = 1;
			amigos.Usuario = "Andre";
			amigos.UrlsMidia = "https://images.pexels.com/photos/15045083/pexels-photo-15045083/free-photo-of-moda-tendencia-mulher-carro.jpeg";
            return View(amigos);
		}
        public IActionResult Usuario()
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

