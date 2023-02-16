using Rextur.Domain.DTO;
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
    public class AuthenticacaoApi : IAuthenticacaoApi
    {
        protected HttpClient _httpClient;
        public AuthenticacaoApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

       
        public async Task<string> ObterToken(AuthenticacaoDTO dto)
        {
            try
            {
                var response = await _httpClient.GetAsync("authenticate");
                var token = JsonSerializer.Deserialize<string>(response.Content.ReadAsStringAsync().Result);

                return token;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
