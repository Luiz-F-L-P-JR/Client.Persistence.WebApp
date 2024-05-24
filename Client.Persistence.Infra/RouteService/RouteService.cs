
using Client.Persistence.Infra.RouteService.Interface;

namespace Client.Persistence.Infra.RouteService
{
    public class RouteService : IRouteService
    {
        private string? UrlApiClientPersistence { get; set; }

        public RouteService()
        {
            
        }

        public async Task SetUrlApiClientPersistence(string routeName)
        {
            UrlApiClientPersistence = routeName;
        }

        public async Task<string> GetUrlApiClientPersistence()
        {
            if (!string.IsNullOrEmpty(UrlApiClientPersistence)) 
                return await Task.FromResult(UrlApiClientPersistence);

            return "";
        }

        public async Task<string> GetClientEndPoint()
        {
            return $"{await GetUrlApiClientPersistence()}/Client";
        }

        public async Task<string> GetPublicAreaEndPoint()
        {
            return $"{await GetUrlApiClientPersistence()}/PublicArea";
        }
    }
}
