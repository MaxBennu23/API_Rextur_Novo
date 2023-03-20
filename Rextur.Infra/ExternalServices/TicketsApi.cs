using Newtonsoft.Json;
using Rextur.Domain.DTO;
using Rextur.Domain.Interfaces;
using Rextur.Infra.CrossCutting;
using Rextur.Infra.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rextur.Infra.ExternalServices
{
    public class TicketsApi:ITicketsApi
    {
        protected IHttpClientConnection _httpClientConnection;
        public TicketsApi(IHttpClientConnection httpClientConnection)
        {
            _httpClientConnection = httpClientConnection;
        }

        public async Task<IEnumerable<TicketsResponse>> GetTickets(TicketDto ticketDtoRequest,string authenticationToken)
        {
            
            var requestRoute = $"tickets/agencia/{ticketDtoRequest.idAgencia}/{ticketDtoRequest.isCancel}/{ticketDtoRequest.DateRequest}";
            var response = await _httpClientConnection.GetSomethingAsync(requestRoute, authenticationToken);
            var jsonString = await response.Content.ReadAsStringAsync();
            var responseTicket = JsonConvert.DeserializeObject<IEnumerable<TicketsResponse>>(jsonString);
            return responseTicket;
        }


    }
}
