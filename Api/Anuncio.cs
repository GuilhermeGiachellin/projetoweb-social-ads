using System;
namespace ftec.projweb.sistema.Domain.Entidades
{
    public class Anuncio
    { 
        public Guid Id { get; set; }
        public string UrlImag { get; set; }
        public string Link { get; set; }
        public string PublicoAlvo { get; set; }
        public string genero { get; set; }
        public TipoCategoria Categoria { get; set; }

        public Anuncio()
        {
            this.Id = Guid.NewGuid();
            this.UrlImag = string.Empty;
            this.Link = string.Empty;
            this.PublicoAlvo = string.Empty;
            this.genero = string.Empty;
           

        }
        public enum TipoCategoria
        {
            Moda = 1,
            Turismo = 2,
            Esporte = 3
        }
    }
}
