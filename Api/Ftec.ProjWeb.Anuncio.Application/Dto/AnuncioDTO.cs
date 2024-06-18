using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ftec.ProjWeb.Anuncio.Application.Dto
{
    public class AnuncioDTO
    {
        public Guid Id { get; set; }
        public string UrlImagem { get; set; }
        public string Link { get; set; }
        public string Texto { get; set; }

        public AnuncioDTO() { }
    }
}
