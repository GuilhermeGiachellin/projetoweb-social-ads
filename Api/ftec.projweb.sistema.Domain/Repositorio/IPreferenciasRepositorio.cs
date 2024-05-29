using ftec.projweb.sistema.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ftec.projweb.sistema.Domain.Repositorio
{
    public interface IPreferenciasRepositorio
    {
        void Inserir(Preferencias preferencias);
        void Alterar(Preferencias preferencia);
        void Excluir(Guid id);
        Preferencias Procurar(Guid id);
        List<Preferencias> ProcurarTodos();
    }
}
