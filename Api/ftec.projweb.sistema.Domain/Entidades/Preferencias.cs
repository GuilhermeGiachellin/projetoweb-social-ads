using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ftec.projweb.sistema.Domain.Entidades
{ 
    public class Preferencias
    {
        public Guid Id { get; set; }
        public string Categoria { get; set; }
        public string Recomendar { get; set; }
    
        public Preferencias()
	    {
            this.Id = Guid.NewGuid();
            this.Categoria =  string.Empty;
            this.Recomendar = string.Empty;
        }
    }
}
