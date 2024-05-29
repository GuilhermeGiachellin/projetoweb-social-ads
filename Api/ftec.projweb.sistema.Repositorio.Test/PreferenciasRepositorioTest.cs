using ftec.projweb.sistema.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ftec.projweb.sistema.Repositorio.Test
{
    [TestClass]
    public class preferenciasRepositorioTest
    {
        [TestMethod]
        public void InserirTest()
        {
            var preferenciasRepositorio = new PreferenciasRepositorio();
            try
            {
                preferenciasRepositorio.Inserir(new Domain.Entidades.Preferencias());
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void AlterarTest()
        {
            var preferenciasRepositorioy = new PreferenciasRepositorio();
            try
            {
                preferenciasRepositorio.Alterar(new Domain.Entidades.Pedido());
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void ProcurarTest()
        {
            var preferenciasRepositorio = new PreferenciasRepositorio();
            try
            {
                var preferencias = preferenciasRepositorio.Procurar(Guid.NewGuid());
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void ProcurarTodosTest()
        {
            var preferenciasRepositorio = new PreferenciasRepositorio();
            try
            {
                var preferencias = preferenciasRepositorio.ProcurarTodos();
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
