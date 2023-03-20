using Rextur.Domain.DTO;
using Rextur.Domain.Interfaces;
using Rextur.Domain.Model;
using Rextur.Infra.CrossCutting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Rextur.Infra.ExternalServices
{
    public class AuthenticacaoApi : IAuthenticacaoApi
    {
        protected IHttpClientConnection _httpClientConnection;
        public AuthenticacaoApi(IHttpClientConnection httpClientConnection)
        {
            _httpClientConnection = httpClientConnection;           
        }

       
        public async Task<string> ObterToken(AuthenticacaoDTO dto)
        {
            try

            {               
                var authenticationParameter=System.Text.Json.JsonSerializer.Serialize(dto);
                var contentString = new StringContent(authenticationParameter, Encoding.UTF8, "application/json");
                var response = await _httpClientConnection.PostSomethingAsync("authenticate", contentString);
                var tokenBearer = "";
                if(response.StatusCode==HttpStatusCode.OK)
                {
                    tokenBearer= response.Headers.GetValues("Authorization").FirstOrDefault().Replace("Bearer","").Trim();
                }

                return tokenBearer;

            }        

            catch (Exception)
            {

                throw;
            }
        }
    }
}
