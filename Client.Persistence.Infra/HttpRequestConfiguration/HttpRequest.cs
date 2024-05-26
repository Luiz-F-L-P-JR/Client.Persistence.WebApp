
using Client.Persistence.Infra.HttpRequestConfiguration.Interface;
using System.Text;
using System.Text.Json;

namespace Client.Persistence.Infra.HttpRequestConfiguration
{
    public sealed class HttpRequest : IHttpRequest
    {
        private readonly HttpClient _httpClient;

        public HttpRequest(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> GetAsync(string uri)
        {
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            httpRequestMessage?.Headers.Add("Accept", "application/json");
            httpRequestMessage?.Headers.Add("Authorization", Environment.GetEnvironmentVariable("TOKEN"));

            var response = await _httpClient.SendAsync(httpRequestMessage);

            return response;
        }

        public async Task<HttpResponseMessage> PostAsync<T>(string uri, T item)
        {
            return await DoRequestAsync(HttpMethod.Post, uri, item);
        }

        public async Task<HttpResponseMessage> PutAsync<T>(string uri, T item)
        {
            return await DoRequestAsync(HttpMethod.Put, uri, item);
        }

        public async Task<HttpResponseMessage> DeleteAsync(string uri)
        {
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            httpRequestMessage?.Headers.Add("Accept", "application/json");
            httpRequestMessage?.Headers.Add("Authorization", Environment.GetEnvironmentVariable("TOKEN"));

            var response = await _httpClient.SendAsync(httpRequestMessage);

            return response;
        }

        private async Task<HttpResponseMessage> DoRequestAsync<T>(HttpMethod httpMethod, string uri, T item)
        {
            var httpRequestMessage = new HttpRequestMessage(httpMethod, uri)
            {
                Content = new StringContent(JsonSerializer.Serialize(item), Encoding.UTF8, "application/json")
            };

            httpRequestMessage?.Headers.Add("Accept", "application/json");
            httpRequestMessage?.Headers.Add("Authorization", Environment.GetEnvironmentVariable("TOKEN"));

            var response = await _httpClient.SendAsync(httpRequestMessage);

            return response;
        }
    }
}
