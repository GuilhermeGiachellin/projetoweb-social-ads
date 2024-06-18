using ftec.projweb.sistema.Repositorio.Repositorio;
using Ftec.ProjWeb.Anuncio.Application.Adapter;
using Ftec.ProjWeb.Anuncio.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ftec.ProjWeb.Anuncio.Application.Application
{
    public class AnuncioApplication
    {
        private AnuncioRepository anuncioRepository;

        public AnuncioApplication()
        {
            string strConexao = "Server=localhost;Port=5432;Database=ftec;User Id=postgres;Password=masterkey;";
            this.anuncioRepository = new AnuncioRepository(strConexao);
        }

        public List<AnuncioDTO> SelecionarLista()
        {
            List<AnuncioDTO> anuncioDto = new List<AnuncioDTO>();
            var anuncios = anuncioRepository.SelecionarLista();
            foreach (var anu in anuncios)
            {
                anuncioDto.Add(AnuncioAdapter.ToDto(anu));
            }
            return anuncioDto;
        }
    }
}
