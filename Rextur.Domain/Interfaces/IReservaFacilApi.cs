using Rextur.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rextur.Domain.Interfaces
{
    public interface IReservaFacilApi
    {
        Task<Passageiro> ObterPorLocalizador(int loc, bool isCancelado);
    }
}
