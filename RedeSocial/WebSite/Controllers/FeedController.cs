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
        public void CurtirPost(Guid Id)
        {
            new APIHttpClient(urlAPICurtidaComentario).Post("likes/post/" + Id + "/" + UsuarioLogadoSingleton.ReturnInstance().Id);
        }

        [HttpDelete]
        public void DescurtirPost(Guid Id)
        {
            new APIHttpClient(urlAPICurtidaComentario).Delete("likes/post/" + Id + "/" + UsuarioLogadoSingleton.ReturnInstance().Id);
        }

        public void Comentar(Guid idPost)
        {
            new APIHttpClient(urlAPICurtidaComentario).Delete("likes/post/" + idPost + "/" + UsuarioLogadoSingleton.ReturnInstance().Id);
        }
    }
}
