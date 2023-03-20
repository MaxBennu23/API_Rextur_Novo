using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Rextur.Infra.CrossCutting
{
    public class HttpConnectClient:IHttpClientConnection
    {
        protected HttpClient _httpClient;
        public HttpConnectClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> GetSomethingAsync(string url,string bearerToken=null)
        {
            if (!string.IsNullOrEmpty(bearerToken))
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
            var response = await _httpClient.GetAsync(url);            
            return response;
        }

        public async Task<HttpResponseMessage> PostSomethingAsync(string url,StringContent content)
        {
            var response = await _httpClient.PostAsync(url, content);
            
            return response;
        }
    }
}
