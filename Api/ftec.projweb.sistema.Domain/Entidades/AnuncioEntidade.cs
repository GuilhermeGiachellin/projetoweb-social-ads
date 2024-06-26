﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ftec.projweb.sistema.Domain.Entidades
{
    public class AnuncioEntidade
    { 
        public Guid Id { get; set; }
        public string UrlImagem { get; set; }
        public string Texto { get; set; }
        public string Link { get; set; }
        public string PublicoAlvo { get; set; }
        public string genero { get; set; }
        public TipoCategoria Categoria { get; set; }

        public AnuncioEntidade()
        {
            this.Id = Guid.NewGuid();
            this.UrlImagem = string.Empty;
            this.Texto = string.Empty;
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
