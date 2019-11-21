using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class Reunion
    {
        public int ICOD_REUNION { get; set; }
        public DateTime DFEC_REUNION { get; set; }
        public DateTime DHENT_REUNION { get; set; }
        public DateTime DHSAL_REUNION { get; set; }
        public string VLUGAR_REUNION { get; set; }

        public int FK_ICOD_DOCENTE { get; set; }

        public int estado { get; set; }
    }
}
