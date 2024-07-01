using WebSite.Backend.Model;

namespace WebSite.Backend.Singleton
{
	public class UsuarioLogadoSingleton
	{
		public static UsuarioModel _usuarioLogado;
		
		public static void GetInstance(UsuarioModel usuario)
		{				
			_usuarioLogado = usuario;				
		}

		public static UsuarioModel ReturnInstance() { return _usuarioLogado; }

	}
}
