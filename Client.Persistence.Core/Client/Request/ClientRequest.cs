
using Client.Persistence.Core.Client.Request.Interface;
using Client.Persistence.Infra.HttpRequestConfiguration.Interface;
using Client.Persistence.Infra.RouteService.Interface;
using System.Text.Json;

namespace Client.Persistence.Core.Client.Request
{
    public sealed class ClientRequest : IClientRequest
    {
        private readonly IHttpRequest? _httpRequest;
        private readonly IRouteService? _routeService;

        public ClientRequest(IHttpRequest? httpRequest, IRouteService? routeService)
        {
            _httpRequest = httpRequest;
            _routeService = routeService;
        }

        public async Task<IEnumerable<Model.Client>> GetAllAsync()
        {
            var uri = await _routeService.GetClientEndPoint();
            var request = await _httpRequest.GetAsync(uri);

            if (request.IsSuccessStatusCode)
            {
                var clients = JsonSerializer.Deserialize<IEnumerable<Model.Client>>(await request.Content.ReadAsStringAsync(), new JsonSerializerOptions{PropertyNameCaseInsensitive = true});

                return clients;
            }

            return null;
        }

        public async Task<Model.Client> GetAsync(int id)
        {
            var uri = $"{await _routeService.GetClientEndPoint()}/{id}";
            var request = await _httpRequest.GetAsync(uri);

            if (request.IsSuccessStatusCode)
            {
                var client = JsonSerializer.Deserialize<Model.Client>(await request.Content.ReadAsStringAsync(), new JsonSerializerOptions{PropertyNameCaseInsensitive = true});

                return client;
            }

            return null;
        }

        public async Task<Model.Client> GetWithPublicAreaAsync(int id)
        {
            var uri = $"{await _routeService.GetClientEndPoint()}/PublicArea/{id}";
            var request = await _httpRequest.GetAsync(uri);

            if (request.IsSuccessStatusCode)
            {
                string stringAsync = await request.Content.ReadAsStringAsync();
                var client = JsonSerializer.Deserialize<Model.Client>(stringAsync, new JsonSerializerOptions{PropertyNameCaseInsensitive = true});

                return client;
            }

            return null;
        }

        public async Task CreateAsync(Model.Client entity)
        {
            var uri = await _routeService.GetClientEndPoint();
            await _httpRequest.PostAsync(uri, entity);
        }

        public async Task DeleteAsync(int id)
        {
            var uri = $"{await _routeService.GetClientEndPoint()}/{id}";
            await _httpRequest.DeleteAsync(uri);
        }

        public async Task UpdateAsync(Model.Client entity)
        {
            var uri = await _routeService.GetClientEndPoint();
            await _httpRequest.PutAsync(uri, entity);
        }
    }
}
