using Client.Persistence.Core.Client.Model.Interface;
using Client.Persistence.Core.PublicArea.Model.Interface;
using Client.Persistence.Infra.RouteService.Interface;

namespace Client.Persistence.Core.Factory.Interface
{
    public interface IFactory
    {
        IClient ClientBuilder();
        IPublicArea PublicAreaBuilder();
        IRouteService RouteServiceBuilder();
    }
}
