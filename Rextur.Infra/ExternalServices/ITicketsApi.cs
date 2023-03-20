using Rextur.Domain.DTO;
using Rextur.Infra.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rextur.Infra.ExternalServices
{
    public interface ITicketsApi
    {
        public Task<IEnumerable<TicketsResponse>> GetTickets(TicketDto ticketDtoRequest,string authenticationToken);
    }
}
