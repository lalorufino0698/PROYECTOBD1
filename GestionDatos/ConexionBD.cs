using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDatos
{
   public  class ConexionBD
    {
        public static string CadenaConexion
        {
            get
            {
                return "Data Source=HACKEDU; Initial Catalog=REUNION;  Integrated Security =true";
            }
        }
    }
}
