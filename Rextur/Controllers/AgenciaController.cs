using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rextur.Domain.DTO;
using Rextur.Domain.Interfaces;
using Rextur.Domain.Model;
using Rextur.Infra.CrossCutting;
using Rextur.Requests;
using System.Net.Http.Headers;
using System.Net.Http;
using Newtonsoft.Json;
using AutoMapper;
using Rextur.Infra.Responses;
using Rextur.Infra.ExternalServices;

namespace Rextur.Controllers
{
    [Route("api/[controller]/tickets")]
    [ApiController]
    public class AgenciaController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IAuthenticacaoApi _autenticacaoApi;
        private readonly ITicketsApi _ticketsApi;        
        private readonly IMapper _mapper;
        public AgenciaController(IConfiguration configuration,IAuthenticacaoApi authenticacaoApi,ITicketsApi ticketsApi,IMapper mapper)
        {
            _configuration = configuration;
            _autenticacaoApi = authenticacaoApi;
            _ticketsApi = ticketsApi;
            _mapper = mapper;
        }

        [HttpGet("{idAgencia}/{isCancel}/{DateRequest}")]
        // GET: api/Agencia/tickets/Agencia
        public async Task<ActionResult<IEnumerable<TicketsResponse>>> GetTickets(int idAgencia,bool isCancel,string DateRequest)
        {

            var AuthenticationDto = FactoryAuthentication();
            var ticketsRequest=FactoryQueryTicketRequest(idAgencia, isCancel,DateRequest);
            var ticketDtoRequest=_mapper.Map<TicketDto>(ticketsRequest); 
            var authorizationToken = await _autenticacaoApi.ObterToken(AuthenticationDto);
            var response =await  _ticketsApi.GetTickets(ticketDtoRequest, authorizationToken);
            return Ok(response);


        }

        private AuthenticacaoDTO FactoryAuthentication()
        {
            var username = _configuration.GetSection("DadosReservaFacil:Usuario").Value;
            var password = _configuration.GetSection("DadosReservaFacil:Senha").Value;
            return new AuthenticacaoDTO(username, password);
        }

        private QueryTicketsRequest FactoryQueryTicketRequest(int idAgencia, bool isCancel, string DateRequest)
        {
            QueryTicketsRequest queryTicketRequest = new() { idAgencia = idAgencia, isCancel = isCancel, DateRequest = DateRequest };
            return queryTicketRequest;
        }
    }
}
