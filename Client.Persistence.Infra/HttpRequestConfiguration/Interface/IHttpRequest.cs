
namespace Client.Persistence.Infra.HttpRequestConfiguration.Interface
{
    public interface IHttpRequest
    {
        Task<HttpResponseMessage> GetAsync(string uri);

        Task<HttpResponseMessage> PostAsync<T>(string uri, T item);

        Task<HttpResponseMessage> PutAsync<T>(string uri, T item);

        Task<HttpResponseMessage> DeleteAsync(string uri);
    }
}
