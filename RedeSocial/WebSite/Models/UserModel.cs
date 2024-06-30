namespace WebSite.Models
{
    public class UserModel
    {       
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

		public string Senha { get; set; }

        public DateTime DataComemorativa { get; set; }

		public string? UrlFoto { get; set; }

        public string? Cidade { get; set; }

        public string? Uf { get; set; }

        public string? Bio { get; set; }

        public string? Telefone { get; set; }

    }
}
