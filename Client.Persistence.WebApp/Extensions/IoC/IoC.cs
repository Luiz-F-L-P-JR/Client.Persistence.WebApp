using Client.Persistence.Core.Client.Request;
using Client.Persistence.Core.Client.Request.Interface;
using Client.Persistence.Core.Client.Service;
using Client.Persistence.Core.Client.Service.Interface;
using Client.Persistence.Core.PublicArea.Request;
using Client.Persistence.Core.PublicArea.Request.Interface;
using Client.Persistence.Core.PublicArea.Service;
using Client.Persistence.Core.PublicArea.Service.Interface;

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
            #endregion
        }
    }
}
