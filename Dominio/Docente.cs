using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Docente
    {
        public int ICOD_DOCENTE { get; set; }
        public string VNOMBRE_DOCENTE { get; set; }
        public string VAPATERNO_DOCENTE { get; set; }
        public string VAMATERNO_DOCENTE { get; set; }
        public int FK_ICOD_CARGO { get; set; }
        public int estado { get; set; }
    }
}
