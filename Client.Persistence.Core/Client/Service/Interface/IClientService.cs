using Client.Persistence.Core.Generics.Interface;

namespace Client.Persistence.Core.Client.Service.Interface
{
    public interface IClientService : IGenericsInteface<Model.Client>
    {
        Task<Model.Client> GetWithPublicAreaAsync(int id);
    }
}
