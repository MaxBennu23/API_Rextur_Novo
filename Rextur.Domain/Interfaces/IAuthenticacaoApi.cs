using Rextur.Domain.DTO;
using Rextur.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rextur.Domain.Interfaces
{
    public interface IAuthenticacaoApi
    {
        Task<string> ObterToken(AuthenticacaoDTO dto);
    }
}
