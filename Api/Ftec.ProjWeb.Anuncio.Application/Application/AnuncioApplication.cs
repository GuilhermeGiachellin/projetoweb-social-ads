using ftec.projweb.sistema.Domain.Entidades;
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
            string strConexao = "Server=pgsql.jmenzen.com.br;Port=5432;Database=jmenzen;User Id=jmenzen;Password='8N9;FLC?;@?I';";
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

        public Guid Inserir(AnuncioDTO anuncio)
        {
            AnuncioEntidade anu = AnuncioAdapter.ToDomain(anuncio);
            anu.Id = Guid.NewGuid();
            anuncioRepository.Inserir(anu);
            return anu.Id;
        }
    }
}
