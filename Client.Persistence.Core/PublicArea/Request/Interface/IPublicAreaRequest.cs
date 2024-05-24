﻿
namespace Client.Persistence.Core.PublicArea.Request.Interface
{
    public interface IPublicAreaRequest
    {
        Task DeleteAsync(int id);
        Task CreateAsync(Model.PublicArea entity);
        Task UpdateAsync(Model.PublicArea entity);
        Task<IEnumerable<Model.PublicArea>> GetAllAsync();
        Task<Model.PublicArea> GetAsync(int id);
    }
}
