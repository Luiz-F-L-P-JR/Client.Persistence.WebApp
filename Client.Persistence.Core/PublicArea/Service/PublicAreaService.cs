

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

        public async Task<IEnumerable<Model.PublicArea>> GetAllAsync()
            => await _publicAreaRequest.GetAllAsync();

        public async Task CreateAsync(Model.PublicArea entity)
            => await _publicAreaRequest.CreateAsync(entity);

        public async Task DeleteAsync(int id)
            => await _publicAreaRequest.DeleteAsync(id);

        public async Task<Model.PublicArea> GetAsync(int id)
            => await _publicAreaRequest.GetAsync(id);

        public async Task UpdateAsync(Model.PublicArea entity)
            => await _publicAreaRequest.UpdateAsync(entity);
    }
}
