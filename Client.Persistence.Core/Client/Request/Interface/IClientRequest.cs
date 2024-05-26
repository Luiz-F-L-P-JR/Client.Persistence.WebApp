
using Client.Persistence.Core.Generics.Interface;

namespace Client.Persistence.Core.Client.Request.Interface
{
    public interface IClientRequest : IGenericsInteface<Model.Client>
    {
        Task<Model.Client> GetWithPublicAreaAsync(int id);
    }
}
