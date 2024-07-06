using WebSite.Backend.Model;
using WebSite.Models;

namespace WebSite.Backend.Singleton
{
	public class PostComentarioSingleton
	{
		public static ComentarioPostModel _comentarioNovo;

		public static void GetInstance(ComentarioPostModel comentario)
		{
			_comentarioNovo = comentario;
		}

		public static ComentarioPostModel ReturnInstance() { return _comentarioNovo; }

		public static void DeleteSingleton() { _comentarioNovo = null; }
	}
}
