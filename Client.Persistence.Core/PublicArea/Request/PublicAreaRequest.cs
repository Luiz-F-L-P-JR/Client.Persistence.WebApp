
using Client.Persistence.Core.PublicArea.Request.Interface;
using Client.Persistence.Infra.HttpRequestConfiguration.Interface;
using Client.Persistence.Infra.RouteService.Interface;
using System.Text.Json;

namespace Client.Persistence.Core.PublicArea.Request
{
    public sealed class PublicAreaRequest : IPublicAreaRequest
    {
        private readonly IHttpRequest? _httpRequest;
        private readonly IRouteService? _routeService;

        public PublicAreaRequest(IHttpRequest? httpRequest, IRouteService? routeService)
        {
            _httpRequest = httpRequest;
            _routeService = routeService;
        }

        public async Task<IEnumerable<Model.PublicArea>> GetAllAsync()
        {
            var uri = await _routeService.GetPublicAreaEndPoint();
            var request = await _httpRequest.GetAsync(uri);

            if (request.IsSuccessStatusCode)
            {
                var publicAreas = JsonSerializer.Deserialize<IEnumerable<Model.PublicArea>>(await request.Content.ReadAsStringAsync());

                return publicAreas;
            }

            return null;
        }

        public async Task<Model.PublicArea> GetAsync(int id)
        {
            var uri = $"{await _routeService.GetPublicAreaEndPoint()}/{id}";
            var request = await _httpRequest.GetAsync(uri);
            return null;
        }

        public async Task CreateAsync(Model.PublicArea publicArea)
        {
            var uri = await _routeService.GetPublicAreaEndPoint();
            var request = await _httpRequest.PostAsync(uri, publicArea);
        }

        public async Task UpdateAsync(Model.PublicArea publicArea)
        {
            var uri = await _routeService.GetPublicAreaEndPoint();
            var request = await _httpRequest.PutAsync(uri, publicArea);
        }

        public async Task DeleteAsync(int id)
        {
            var uri = $"{await _routeService.GetPublicAreaEndPoint()}/{id}";
            var request = await _httpRequest.DeleteAsync(uri);
        }
    }
}
