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

        [HttpPost]
        public Guid Post(AnuncioModel anuncio)
        {
            AnuncioApplication app = new AnuncioApplication();
            return app.Inserir(AnuncioMapping.ToDto(anuncio));
        }

        [HttpDelete("{id:Guid}")]
        public void Delete(Guid id)
        {
            AnuncioApplication app = new AnuncioApplication();
            app.Excluir(id);
        }

        [HttpPut]
        public Guid Put(AnuncioModel anuncio)
        {
            AnuncioApplication app = new AnuncioApplication();
            return app.Alterar(AnuncioMapping.ToDto(anuncio));
        }

    }
}
