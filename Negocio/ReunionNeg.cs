using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dominio;
using GestionDatos;

namespace Negocio
{
   public class ReunionNeg
    {



        ReunionDat objReunionDat;

        public ReunionNeg()
        {
            objReunionDat = new ReunionDat();
        }
        public void InsertReunion(Reunion objReunion)
        {
           
            //Ingresar curso a la tabla
            objReunionDat.InserReunion(objReunion);
            objReunion.estado = 99;
        }


        public bool LeerReunion(Reunion objReunion)
        {
            return objReunionDat.SelectReunion(objReunion);
        }

        public DataSet LeerReunionds()
        {
            return objReunionDat.SelectReunionds();
        }
    }
}
