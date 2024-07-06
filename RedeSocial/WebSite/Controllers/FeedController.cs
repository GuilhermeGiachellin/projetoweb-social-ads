using Microsoft.AspNetCore.Mvc;
using WebSite.Backend.HTTPClient;
using WebSite.Backend.Singleton;

namespace WebSite.Controllers
{
    public class FeedController : Controller
    {
        private static readonly string urlAPICurtidaComentario = "http://grupo4.neurosky.com.br/api/";
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CurtirPost(Guid Id)
        {
            new APIHttpClient(urlAPICurtidaComentario).Post("likes/post/" + Id + "/" + UsuarioLogadoSingleton.ReturnInstance().Id);
            return Redirect("Usuario/UsuarioPerfil");
        }

        [HttpDelete]
        public IActionResult DescurtirPost(Guid Id)
        {
            new APIHttpClient(urlAPICurtidaComentario).Delete("likes/post/" + Id + "/" + UsuarioLogadoSingleton.ReturnInstance().Id);
			return Redirect("Usuario/UsuarioPerfil");
		}

        public void Comentar(Guid idPost)
        {
            new APIHttpClient(urlAPICurtidaComentario).Delete("likes/post/" + idPost + "/" + UsuarioLogadoSingleton.ReturnInstance().Id);
        }

        [HttpPost]
		public IActionResult CurtirComentario(Guid Id)
        {
            new APIHttpClient(urlAPICurtidaComentario).Post("likes/comentario/" + Id + "/" + UsuarioLogadoSingleton.ReturnInstance().Id);
			return Redirect("Usuario/UsuarioPerfil");
		}
	}
}
