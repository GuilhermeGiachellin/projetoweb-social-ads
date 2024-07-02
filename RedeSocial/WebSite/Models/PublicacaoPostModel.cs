namespace WebSite.Models
{
	public class PublicacaoPostModel
	{
		public Guid Id { get; set; }
		public string Usuario { get; set; }
		public string Descricao { get; set; }
		public DateTime DataPublicacao { get; set; }
	}
}
