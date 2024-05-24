using Client.Persistence.Core.Client.Request;
using Client.Persistence.Core.Client.Request.Interface;
using Client.Persistence.Core.Client.Service;
using Client.Persistence.Core.Client.Service.Interface;
using Client.Persistence.Core.Factory;
using Client.Persistence.Core.Factory.Interface;
using Client.Persistence.Core.PublicArea.Request;
using Client.Persistence.Core.PublicArea.Request.Interface;
using Client.Persistence.Core.PublicArea.Service;
using Client.Persistence.Core.PublicArea.Service.Interface;
using Client.Persistence.Infra.HttpRequestConfiguration.Interface;
using Client.Persistence.Infra.RouteService.Interface;

namespace Client.Persistence.WebApp.Extensions.IoC
{
    public static class IoC
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            #region Client Injection
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IClientRequest, ClientRequest>();
            #endregion

            #region Public Area Injection
            services.AddScoped<IPublicAreaService, PublicAreaService>();
            services.AddScoped<IPublicAreaRequest, PublicAreaRequest>();
            #endregion

            #region Http Injection
            services.AddSingleton<HttpClient>();
            services.AddSingleton<IHttpRequest, Infra.HttpRequestConfiguration.HttpRequest>();
            #endregion

            #region Router Injection

            services.AddSingleton(option =>
            {
                IFactory factory = new Factory();
                IRouteService router = factory.RouteServiceBuilder();

                var route = Environment.GetEnvironmentVariable("ROUTE");
                var teste = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

                router.SetUrlApiClientPersistence(route);

                return router;
            });

            #endregion            
        }
    }
}