using Client.Persistence.Core.Client.Service.Interface;

namespace Client.Persistence.Core.Client.Service
{
    public sealed class ClientService : IClientService
    {
        public Task CreateAsync(Model.Client entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Model.Client>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Model.Client>> GetAllWithPublicAreaAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Model.Client> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Model.Client> GetWithPublicAreaAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Model.Client entity)
        {
            throw new NotImplementedException();
        }
    }
}
