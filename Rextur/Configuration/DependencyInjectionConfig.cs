using NuGet.Configuration;
using Rextur.AutoMapper;
using Rextur.Domain.Interfaces;
using Rextur.Infra.CrossCutting;
using Rextur.Infra.ExternalServices;

namespace Rextur.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void ResolveDependencies(this IServiceCollection services, IConfiguration configuration) 
        {          
            
            services.AddHttpClient<IHttpClientConnection, HttpConnectClient>(services =>
            services.BaseAddress = new Uri(configuration.GetSection("DadosReservaFacil:URL").Value));           
            services.AddScoped<IAuthenticacaoApi, AuthenticacaoApi>();
            services.AddScoped<ITicketsApi, TicketsApi>();
            services.AddAutoMapper(typeof(AutoMapperSetup));
        }
    }
}
