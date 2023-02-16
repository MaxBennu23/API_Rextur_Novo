using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rextur.Domain.Settings
{
    public class ReservaFacilSettings
    {
       
        public string Username { get; set; }
        public string Password { get; set; }
        public int IdAgencia { get; set; }

    }
}

///dependecia a ser injetada na classe inteira