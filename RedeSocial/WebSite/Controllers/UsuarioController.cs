﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using WebSite.Backend.Adapter;
using WebSite.Backend.HTTPClient;
using WebSite.Backend.Model;
using WebSite.Backend.Singleton;
using WebSite.Factory;
using WebSite.Models;


namespace WebSite.Controllers
{
	public class UsuarioController : Controller
	{
		private static readonly string urlAPIUsuario = "http://grupo3.neurosky.com.br/api/";
		private List<PublicacaoModel> _listaPublicacoes = new List<PublicacaoModel>();
		private List<ComentarioModel> _listaComentarios = new List<ComentarioModel>();
		private List<AnuncioModel> _listaAnuncios = new List<AnuncioModel>();
		List<Guid> _listaIdCurtidas = new List<Guid>();
		private List<FeedModel> _feeds = new List<FeedModel>();

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

		[HttpPost]
		public IActionResult UsuarioPublicacao(PublicacaoModel post)
		{


			return View();
		}



		[HttpGet]
		public IActionResult UsuarioPerfil()
		{
			GetPublicacoes();
			GetAnuncios();
			BuildFeed();

			ViewBag.Feed = _feeds;
			ViewBag.Anuncios = _listaAnuncios;
			return View();
		}

		public void GetAnuncios()
		{
			_listaAnuncios =
				new APIHttpClient("http://grupo1.neurosky.com.br/api/").Get<List<AnuncioModel>>("anuncio");
		}

		public void GetPublicacoes()
		{
			_listaPublicacoes = 
				new APIHttpClient("http://grupo5.neurosky.com.br/api/").Get<List<PublicacaoModel>>("Publicacao?idUsuario=" + UsuarioLogadoSingleton.ReturnInstance().Id);
		}

		public int GetCurtidasPorPost(Guid id)
		{
			_listaIdCurtidas =
				new APIHttpClient("http://grupo4.neurosky.com.br/api/").Get<List<Guid>>("comentarios/post/" + id);

			if (_listaIdCurtidas.Count > 0)
				return _listaIdCurtidas.Count;
			else 
				return 0;
		}
		
		public void getComentariosPorPost(Guid idPost)
		{
			_listaComentarios =
				new APIHttpClient("http://grupo4.neurosky.com.br/api/").Get<List<ComentarioModel>>("comentarios/post/" + idPost);
		}

		public UsuarioModel getPostOwner(Guid idUsuario)
		{
			return new APIHttpClient(urlAPIUsuario).Get<WebSite.Backend.Model.UsuarioModel>("usuario/" + idUsuario);
		}

		public bool DidLoggedUserLike()
		{			
			return _listaIdCurtidas.Where(x => x == UsuarioLogadoSingleton.ReturnInstance().Id).Count() >= 1;			
		}

		public List<string> getListaMidias(PublicacaoModel publicacao)
		{
			List<string> listaMidias = new List<string>();
			if (publicacao.Midias.Count >= 1)
			{
				foreach (var midia in publicacao.Midias)
				{
					listaMidias.Add(midia.FileContents);
				}
			}
			return listaMidias;
		}

		public void BuildFeed()
		{
			foreach (var publicacao in _listaPublicacoes)
			{				
				getComentariosPorPost(publicacao.Id);									

				FeedModel feed = new FeedModel()
				{
					Id = publicacao.Id,
					Descricao = publicacao.Descricao,
					Curtidas = GetCurtidasPorPost(publicacao.Id),
					DataPublicacao = publicacao.DataPublicacao,
					DidLike = DidLoggedUserLike(),
					ListaComentarios = _listaComentarios,
					ListaMidia = getListaMidias(publicacao),
					Usuario = getPostOwner(publicacao.Usuario)
			};
				_feeds.Add(feed); 
			}		
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
            var response = new APIHttpClient(urlAPIUsuario).Post<UsuarioLogin, Backend.Model.UsuarioModel>("Usuario/Login", apiModel);
            
            if (response is not null)
			{                
                ViewBag.UsuarioLogado = UsuarioAdapter.ToUsuarioCadastroModel(response);
				UsuarioLogadoSingleton.GetInstance(response);
                return Redirect("Usuario/UsuarioPerfil");
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

