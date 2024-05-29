using ftec.projweb.sistema.Repositorio.Repositorio;


namespace ftec.projweb.sistema.Repositorio.Test
{

    [TestClass]
    public class AnuncioRepositorioTest
    {
        [TestMethod]
        public void InserirTest()
        {
            var anuncioRepositorio = new AnuncioRepositorio();
            try
            {
                anuncioRepositorio.Inserir(new Domain.Entidades.Anuncio());
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
            var anuncioRepositorio = new AnuncioRepositorio();
            try
            {
                anuncioRepositorio.Alterar(new Domain.Entidades.anuncio());
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
            var anuncioRepositorio = new AnuncioRepositorio();
            try
            {
                var anuncio = anuncioRepositorio.Procurar(Guid.NewGuid());
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
            var anuncioRepositorio = new anuncioRepositorio();
            try
            {
                var Anuncio = anuncioRepositorio.ProcurarTodos();
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
