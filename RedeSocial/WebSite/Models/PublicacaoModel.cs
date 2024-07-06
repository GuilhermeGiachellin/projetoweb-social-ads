namespace WebSite.Models
{
	public class PublicacaoModel
	{
		public Guid Id { get; set; }
		public Guid Usuario { get; set; }
		public string Descricao { get; set; }
		public DateTime DataPublicacao { get; set; }
		public List<MidiaPublicacaoModel>? Midias { get; set; }	
		
	}
}
