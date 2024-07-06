namespace WebSite.Models
{
	public class ComentarioPostModel
	{
		public Guid Id { get; set; }

		public Guid IdUsuario { get; set; }

		public DateTime DataCriacao { get; set; }

		public DateTime DataEdicao { get; set; }

		public long QuantidadeLikes { get; set; }

	}
}
