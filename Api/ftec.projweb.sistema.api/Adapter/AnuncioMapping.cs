using ftec.projweb.sistema.api.Model;
using Ftec.ProjWeb.Anuncio.Application.Dto;

namespace ftec.projweb.sistema.api.Adapter
{
    public class AnuncioMapping
    {
        public static AnuncioModel ToModel(AnuncioDTO anuncio)
        {
            if (anuncio == null)
                return null;
            else
            {
                AnuncioModel anuncioModel = new AnuncioModel();
                anuncioModel.Id = anuncio.Id;
                anuncioModel.Texto = anuncio.Texto;
                anuncioModel.UrlImagem = anuncio.UrlImagem;
                anuncioModel.Link = anuncio.Link;

                return anuncioModel;
            }
        }

        public static AnuncioDTO ToDto(AnuncioModel anuncio)
        {
            if (anuncio == null)
                return null;
            else
            {
                AnuncioDTO anuncioDto = new AnuncioDTO();
                anuncioDto.Texto = anuncio.Texto;
                anuncioDto.UrlImagem = anuncio.UrlImagem;
                anuncioDto.Link = anuncio.Link;
                                
                return anuncioDto;
            }
        }
    }
}
