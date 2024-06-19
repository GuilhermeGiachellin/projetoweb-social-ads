using ftec.projweb.sistema.Domain.Entidades;
using Ftec.ProjWeb.Anuncio.Application.Dto;


namespace Ftec.ProjWeb.Anuncio.Application.Adapter
{
    public class AnuncioAdapter
    {
        public static AnuncioEntidade ToDomain(AnuncioDTO anuncio)
        {
            if (anuncio == null)
                return null;
            else
            {
                AnuncioEntidade anuncioDomain = new AnuncioEntidade();
                anuncioDomain.Id = anuncio.Id;
                anuncioDomain.UrlImagem = anuncio.UrlImagem;
                anuncioDomain.Texto = anuncio.Texto;
                anuncioDomain.UrlImagem = anuncio.UrlImagem;
                anuncioDomain.Link = anuncio.Link;

                return anuncioDomain;
            }
        }

        public static AnuncioDTO ToDto(AnuncioEntidade anuncio)
        {
            if (anuncio == null)
                return null;
            else
            {
                AnuncioDTO anuncioDto = new AnuncioDTO();
                anuncioDto.Id = anuncio.Id;
                anuncioDto.Texto = anuncio.Texto;
                anuncioDto.UrlImagem = anuncio.UrlImagem;
                anuncioDto.Link = anuncio.Link;

                return anuncioDto;
            }
        }
    }
}
