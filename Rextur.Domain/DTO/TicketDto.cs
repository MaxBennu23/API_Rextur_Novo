using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rextur.Domain.DTO
{
    public class TicketDto
    {
        public int idAgencia { get; set; }

        public bool isCancel { get; set; }

        public string DateRequest { get; set; }
    }
}
