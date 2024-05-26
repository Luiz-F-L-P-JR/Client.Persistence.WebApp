
namespace Client.Persistence.Core.Generics.Interface
{
    public interface IGenericsInteface <T> where T : class
    {
        Task DeleteAsync(int id);
        Task<T> GetAsync(int id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task<IEnumerable<T>> GetAllAsync();
    }
}
