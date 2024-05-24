
namespace Client.Persistence.Infra.RouteService.Interface
{
    public interface IRouteService
    {
        Task<string> GetUrlApiClientPersistence();
        Task SetUrlApiClientPersistence(string route);

        Task<string> GetClientEndPoint();
        Task<string> GetPublicAreaEndPoint();
    }
}
