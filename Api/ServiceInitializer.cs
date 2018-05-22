using Microsoft.Extensions.DependencyInjection;
using Nkolay.Web.Api.Service.Interfaces;
using Nkolay.Web.Api.Service.Services;

namespace Nkolay.Web.Api
{
    public class ServiceInitializer
    {

        public void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IOyunPiniService, OyunPiniService>();
        }
        
    }
}