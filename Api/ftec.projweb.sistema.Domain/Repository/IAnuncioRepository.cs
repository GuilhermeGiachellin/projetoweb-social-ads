using ftec.projweb.sistema.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ftec.projweb.sistema.Domain.Repositorio
{
    public interface IAnuncioRepository
    {
        void Inserir(AnuncioEntidade anuncio);
        void Alterar(AnuncioEntidade anuncio);
        void Excluir(Guid id);
        AnuncioEntidade Procurar(Guid id);
        List<AnuncioEntidade> SelecionarLista();
    }
}
