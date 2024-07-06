namespace WebSite.Models
{
	public class ComentarioPostModel
	{
		public Guid id { get; set; }

		public Guid idUsuario { get; set; }

		public DateTime dataCriacao { get; set; }

		public DateTime dataEdicao { get; set; }

		public long quantidadeLikes { get; set; }
		public string conteudo { get; set; }
	
	}
}
