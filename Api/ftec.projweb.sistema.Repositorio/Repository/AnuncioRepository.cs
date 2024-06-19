using ftec.projweb.sistema.Domain.Entidades;
using ftec.projweb.sistema.Domain.Repositorio;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ftec.projweb.sistema.Repositorio.Repositorio;

public class AnuncioRepository : IAnuncioRepository
{
    private string strConexao;
    public AnuncioRepository(string strConexao = null)
    {
        this.strConexao = strConexao;
    }


    public void Alterar(AnuncioEntidade anuncio)
    {
        //throw new NotImplementedException();
    }

    public void Excluir(Guid id)
    {
        throw new NotImplementedException();
    }

    public void Inserir(AnuncioEntidade anuncio)
    {
        using (NpgsqlConnection con = new NpgsqlConnection(strConexao))
        {
            con.Open();
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO public.anuncio (id, urlImagem, link, texto) values(@id, @urlImagem, @link, @texto)";
                cmd.Parameters.AddWithValue("urlImagem", anuncio.UrlImagem);
                cmd.Parameters.AddWithValue("link", anuncio.Link);
                cmd.Parameters.AddWithValue("texto", anuncio.Texto);
                cmd.Parameters.AddWithValue("id", anuncio.Id);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public AnuncioEntidade Procurar(Guid id)
    {
        throw new NotImplementedException();
    }

    public List<AnuncioEntidade> SelecionarLista()
    {
        List<AnuncioEntidade> anuncios = new List<AnuncioEntidade>();
        using (NpgsqlConnection con = new NpgsqlConnection(strConexao)) 
        { 
            con.Open();
            using (NpgsqlCommand cmd = new NpgsqlCommand())
            {
                cmd.Connection = con;
                cmd.CommandText = "Select id, urlImagem, texto, link from anuncio";
                var leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    var anuncio = new AnuncioEntidade();
                    anuncio.Id = Guid.Parse(leitor["id"].ToString());
                    anuncio.Texto  = leitor["texto"].ToString();
                    anuncio.UrlImagem = leitor["urlImagem"].ToString();
                    anuncio.Link = leitor["link"].ToString();
                    anuncios.Add(anuncio);
                }
                leitor.Close();         


            }
        }
        return anuncios;

    }       
    
}

