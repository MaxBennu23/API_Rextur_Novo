using NuGet.Configuration;
using Rextur.Domain.Interfaces;
using Rextur.Domain.Settings;
using Rextur.Infra.ExternalServices;

namespace Rextur.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void ResolveDependencies(this IServiceCollection services, IConfiguration configuration) {

            services.AddScoped<IReservaFacilApi, ResevaFacilApi>();

            services.AddHttpClient<IReservaFacilApi,ResevaFacilApi>(services => 
                services.BaseAddress = new Uri(configuration.GetSection("DadosReservaFacil:URL").Value) );

            var settings = new ReservaFacilSettings {
              
                Username = configuration.GetSection("DadosReservaFacil:Username").Value,
                Password = configuration.GetSection("DadosReservaFacil:Password").Value,
                IdAgencia = Convert.ToInt32( configuration.GetSection("DadosReservaFacil:IdAgencia").Value),
            };

            services.AddSingleton(settings);

        }// void só chama
    }
}
