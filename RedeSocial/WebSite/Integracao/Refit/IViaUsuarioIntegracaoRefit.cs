using Refit;
using WebSite.Integracao.Responce;

namespace WebSite.Integracao.Refit
{
	public interface IViaUsuarioIntegracaoRefit
	{
		[Get("")]
		Task<ApiResponse<ViaUsuarioResponse>> ObterDadosViaUsuario(string nome);
	}
}
