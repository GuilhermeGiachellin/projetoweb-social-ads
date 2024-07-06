using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebSite.Backend.HTTPClient;
using WebSite.Backend.Singleton;
using WebSite.Factory;
using WebSite.Models;

namespace WebSite.Controllers
{
	public class FeedController : Controller
	{
		private static readonly string urlAPICurtidaComentario = "http://grupo4.neurosky.com.br/api/";
		public IActionResult Index()
		{
			return View();
		}

		/*public List<FeedModel> getFeed()
		{
            List <FeedModel> listaFeed = new List<FeedModel>();

			listaFeed = MoqFactory.GerarListaFeed(5);

            return listaFeed;
		}*/

		[HttpPost]
		public void CurtirPost(Guid idPost)
		{			
			new APIHttpClient(urlAPICurtidaComentario).Post("likes/post/" + idPost + "/" + UsuarioLogadoSingleton.ReturnInstance().Id);			
		}

		[HttpDelete]
		public void DescurtirPost(Guid idPost)
		{
			new APIHttpClient(urlAPICurtidaComentario).Delete("likes/post/" + idPost + "/" + UsuarioLogadoSingleton.ReturnInstance().Id);
		}

		public void Comentar(Guid idPost)
		{
			new APIHttpClient(urlAPICurtidaComentario).Delete("likes/post/" + idPost + "/" + UsuarioLogadoSingleton.ReturnInstance().Id);
		}
	}
}
