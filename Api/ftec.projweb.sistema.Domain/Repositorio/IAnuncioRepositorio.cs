using ftec.projweb.sistema.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ftec.projweb.sistema.Domain.Repositorio
{
    public interface IAnuncioRepositorio
    {
        void Inserir(Anuncio anuncio);
        void Alterar(Anuncio anuncio);
        void Excluir(Guid id);
        Anuncio Procurar(Guid id);
        List<Anuncio> ProcurarTodos();
    }
}
