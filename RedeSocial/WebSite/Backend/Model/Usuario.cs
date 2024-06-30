﻿using System.ComponentModel.DataAnnotations;
using WebSite.Models;

namespace WebSite.Backend.Model
{
    public class UsuarioModel
    {        
            public Guid Id { get; set; }
            public string Email { get; set; }
            public string Nome { get; set; }
            public string Sobrenome { get; set; }
            public string Senha { get; set; }
            public DateTime DataComemorativa { get; set; }
            public GeneroModel Sexo { get; set; }
            public string Bio { get; set; }
            public string FotoPerfil { get; set; }
            public string Cidade { get; set; }
            public UFModel Uf { get; set; }
            public string Telefone { get; set; }
            public string Documento { get; set; }
            public TipoPessoaModel Tipo { get; set; }
            public List<UsuarioModel> Amigos { get; set; }

            public bool UsuarioAmigo(Guid id) => Amigos.Any(a => a.Id == id);
            public List<UsuarioModel> ObterPrimeirosAmigos() => Amigos.Take(4).ToList();
            public string FotoDePerfilTratada
            {
                get
                {
                    return string.IsNullOrEmpty(FotoPerfil)
                        ? "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"
                        : FotoPerfil;
                }
            }

        }


        public enum UFModel
        {
            [Display(Name = "Acre")]
            AC,
            [Display(Name = "Alagoas")]
            AL,
            [Display(Name = "Amapá")]
            AP,
            [Display(Name = "Amazonas")]
            AM,
            [Display(Name = "Bahia")]
            BA,
            [Display(Name = "Ceará")]
            CE,
            [Display(Name = "Distrito Federal")]
            DF,
            [Display(Name = "Espírito Santo")]
            ES,
            [Display(Name = "Goiás")]
            GO,
            [Display(Name = "Maranhão")]
            MA,
            [Display(Name = "Mato Grosso")]
            MT,
            [Display(Name = "Mato Grosso do Sul")]
            MS,
            [Display(Name = "Minas Gerais")]
            MG,
            [Display(Name = "Pará")]
            PA,
            [Display(Name = "Paraíba")]
            PB,
            [Display(Name = "Paraná")]
            PR,
            [Display(Name = "Pernambuco")]
            PE,
            [Display(Name = "Piauí")]
            PI,
            [Display(Name = "Rio de Janeiro")]
            RJ,
            [Display(Name = "Rio Grande do Norte")]
            RN,
            [Display(Name = "Rio Grande do Sul")]
            RS,
            [Display(Name = "Rondônia")]
            RO,
            [Display(Name = "Roraima")]
            RR,
            [Display(Name = "Santa Catarina")]
            SC,
            [Display(Name = "São Paulo")]
            SP,
            [Display(Name = "Sergipe")]
            SE,
            [Display(Name = "Tocantins")]
            TO
        }

        public enum TipoPessoaModel
        {
            Fisica = 0,
            Juridica = 1
        }

        public enum GeneroModel
        {
            [Display(Name = "Masculino")]
            Masculino = 0,
            [Display(Name = "Feminino")]
            Feminino = 1
        }
    }

