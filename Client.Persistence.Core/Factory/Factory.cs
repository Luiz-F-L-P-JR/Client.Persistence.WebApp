using Client.Persistence.Core.Client.Model.Interface;
using Client.Persistence.Core.Factory.Interface;
using Client.Persistence.Core.PublicArea.Model.Interface;
using Client.Persistence.Infra.RouteService;
using Client.Persistence.Infra.RouteService.Interface;

namespace Client.Persistence.Core.Factory
{
    public sealed class Factory : IFactory
    {
        public IClient ClientBuilder()
        {
            return new Client.Model.Client();
        }

        public IPublicArea PublicAreaBuilder()
        {
            return new PublicArea.Model.PublicArea();
        }

        public IRouteService RouteServiceBuilder()
        {
            return new RouteService();
        }
    }
}
