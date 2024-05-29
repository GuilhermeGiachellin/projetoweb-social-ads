using ftec.projweb.sistema.Domain.Entidades;
using ftec.projweb.sistema.Domain.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ftec.projweb.sistema.Repositorio.Repositorio;

public class AnuncioRepositorio : IAnuncioRepositorio
{
    public void Alterar(Anuncio anuncio)
    {
        //throw new NotImplementedException();
    }

    public void Excluir(Guid id)
    {
        throw new NotImplementedException();
    }

    public void Inserir(Anuncio anuncio)
    {
        throw new NotImplementedException();
    }

    public Anuncio Procurar(Guid id)
    {
        throw new NotImplementedException();
    }

    public List<Anuncio> ProcurarTodos()
    {
        throw new NotImplementedException();
    }
}

