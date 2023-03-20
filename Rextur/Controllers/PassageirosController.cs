using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using Microsoft.EntityFrameworkCore;
using Rextur.Data;
using Rextur.Domain.DTO;
using Rextur.Domain.Interfaces;
using Rextur.Domain.Model;
using Rextur.Infra.CrossCutting;
using System.Net.Http;
using System.Text.Json;

namespace Rextur.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassageirosController : ControllerBase
    {
        //private readonly PassageirosContext _context;
        private readonly IReservaFacilApi _reservafacilapi;
        private readonly IAuthenticacaoApi _autenticacaoApi;
       

        public PassageirosController(IReservaFacilApi reservafacilapi,IAuthenticacaoApi autenticacao)
        {
            //_context = context;
            _reservafacilapi = reservafacilapi;
            _autenticacaoApi = autenticacao;
            
        }
      
        // GET: api/Passageiros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Passageiro>>> GetPassageiros()
        {
            //AuthenticacaoDTO authenticateDto = new AuthenticacaoDTO();
            //authenticateDto.Username = "INTEGRACAOINFOTUR";
            //authenticateDto.Password = "integracao1";
            //var authorizationToken = _autenticacaoApi.ObterToken(authenticateDto);
            return Ok();
        }
        // GET: api/Passageiros/Localizador

        [HttpGet("{localizador}")]
        public async Task<ActionResult> GetPorLocalizador(int loc, bool isCancelado)
        {
            var response = _reservafacilapi.ObterPorLocalizador(loc, isCancelado);
            return Ok(response);
        }


        //// GET: api/Passageiros/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Passageiro>> GetPassageiro(int id)
        //{
        //    var passageiro = await _context.Passageiros.FindAsync(id);

        //    if (passageiro == null)
        //    {
        //        return NotFound();
        //    }

        //    return passageiro;
        //}

        // PUT: api/Passageiros/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutPassageiro(int id, Passageiro passageiro)
        //{
        //    if (id != passageiro.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(passageiro).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!PassageiroExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/Passageiros
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Passageiro>> PostPassageiro(Passageiro passageiro)
        //{
        //    _context.Passageiros.Add(passageiro);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetPassageiro", new { id = passageiro.Id }, passageiro);
        //}

        //// DELETE: api/Passageiros/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeletePassageiro(int id)
        //{
        //    var passageiro = await _context.Passageiros.FindAsync(id);
        //    if (passageiro == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Passageiros.Remove(passageiro);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool PassageiroExists(int id)
        //{
        //    return _context.Passageiros.Any(e => e.Id == id);
        //}
    }
}
