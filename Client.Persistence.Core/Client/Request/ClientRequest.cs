
using Client.Persistence.Core.Client.Request.Interface;
using Client.Persistence.Infra.HttpRequestConfiguration.Interface;

namespace Client.Persistence.Core.Client.Request
{
    public sealed class ClientRequest : IClientRequest
    {
        private readonly IHttpRequest? _httpRequest;

        public ClientRequest(IHttpRequest? httpRequest)
        {
            _httpRequest = httpRequest;
        }
    }
}
