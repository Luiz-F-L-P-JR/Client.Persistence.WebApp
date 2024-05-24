

using Client.Persistence.Core.PublicArea.Request.Interface;
using Client.Persistence.Core.PublicArea.Service.Interface;

namespace Client.Persistence.Core.PublicArea.Service
{
    public sealed class PublicAreaService : IPublicAreaService
    {
        private readonly IPublicAreaRequest? _publicAreaRequest;

        public PublicAreaService(IPublicAreaRequest? publicAreaRequest)
        {
            _publicAreaRequest = publicAreaRequest;
        }

        public Task CreateAsync(Model.PublicArea entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Model.PublicArea>> GetAllAsync()
            => await _publicAreaRequest.GetAllAsync();

        public Task<Model.PublicArea> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Model.PublicArea entity)
        {
            throw new NotImplementedException();
        }
    }
}
