using Rextur.Domain.Interfaces;
using Rextur.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Rextur.Infra.ExternalServices
{
    public class ResevaFacilApi : IReservaFacilApi
    {
        protected HttpClient _httpClient;
        public ResevaFacilApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Passageiro> ObterPorLocalizador(int loc, bool isCancelado)
        {
            try
            {
                var response = await _httpClient.GetAsync($"/tickets/loc/{loc}/{isCancelado}");//interpolacao (recebe a resposta )
                var passageiro = JsonSerializer.Deserialize<Passageiro>(response.Content.ReadAsStringAsync().Result);

                return passageiro;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
