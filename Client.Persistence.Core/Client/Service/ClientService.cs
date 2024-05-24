using Client.Persistence.Core.Client.Request.Interface;
using Client.Persistence.Core.Client.Service.Interface;

namespace Client.Persistence.Core.Client.Service
{
    public sealed class ClientService : IClientService
    {
        private readonly IClientRequest? _clientRequest;

        public ClientService(IClientRequest? clientRequest)
        {
            _clientRequest = clientRequest;
        }

        public async Task<IEnumerable<Model.Client>> GetAllAsync()
            => await _clientRequest.GetAllAsync();

        public async Task<IEnumerable<Model.Client>> GetAllWithPublicAreaAsync()
            => await _clientRequest.GetAllWithPublicAreaAsync();

        public async Task<Model.Client> GetAsync(int id)
            => await _clientRequest.GetAsync(id);

        public async Task<Model.Client> GetWithPublicAreaAsync(int id)
            => await _clientRequest.GetWithPublicAreaAsync(id);

        public async Task CreateAsync(Model.Client entity)
            => await _clientRequest.CreateAsync(entity);

        public async Task UpdateAsync(Model.Client entity)
            => await _clientRequest.UpdateAsync(entity);

        public async Task DeleteAsync(int id)
            => await _clientRequest.DeleteAsync(id);
    }
}
