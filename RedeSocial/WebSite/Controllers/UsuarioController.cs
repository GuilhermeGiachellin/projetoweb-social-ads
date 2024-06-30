using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using WebSite.Backend.Adapter;
using WebSite.Backend.HTTPClient;
using WebSite.Backend.Model;
using WebSite.Factory;
using WebSite.Models;


namespace WebSite.Controllers
{
    public class UsuarioController : Controller
    {
		private static readonly string urlAPI = "http://grupo3.neurosky.com.br/api/";

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
		public IActionResult Login(LoginModel loginModel)		{

			var apiModel = UsuarioAdapter.ToUsuarioLoginModel(loginModel);
            var response = new APIHttpClient(urlAPI).Post<UsuarioLogin, Backend.Model.UsuarioModel>("Usuario/Login", apiModel);
            
            if (response is not null)
			{                
                ViewBag.UsuarioLogado = UsuarioAdapter.ToUsuarioCadastroModel(response);
                return Redirect("Postagem/Feed");
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

