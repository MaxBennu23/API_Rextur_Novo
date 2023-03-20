using AutoMapper;
using Rextur.Domain.DTO;
using Rextur.Requests;

namespace Rextur.AutoMapper
{
    public class AutoMapperSetup:Profile
    {
        public AutoMapperSetup()
        {
            CreateMap<QueryTicketsRequest, TicketDto>();
        }
    }
}
