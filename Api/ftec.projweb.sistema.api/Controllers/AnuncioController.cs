using ftec.projweb.sistema.api.Adapter;
using ftec.projweb.sistema.api.Model;
using Ftec.ProjWeb.Anuncio.Application.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ftec.projweb.sistema.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnuncioController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<AnuncioModel> Get()
        {
            List<AnuncioModel> anunciosModel = new List<AnuncioModel>();
            AnuncioApplication app = new AnuncioApplication();
            var anuncios = app.SelecionarLista();
            foreach (var anuncio in anuncios)
            {
                anunciosModel.Add(AnuncioMapping.ToModel(anuncio));
            }
            return anunciosModel.ToArray();
        }

    }
}
