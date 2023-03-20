using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rextur.Infra.CrossCutting
{
    public interface IHttpClientConnection
    {
        Task<HttpResponseMessage> GetSomethingAsync(string query,string bearerToken);

        Task<HttpResponseMessage> PostSomethingAsync(string url, StringContent content);
    }
}
