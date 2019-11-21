using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using GestionDatos;
using System.Data;


namespace Negocio
{
   public class ActividadNeg
    {

        ActividadDat objActividadDat;


        public ActividadNeg()
        {
            objActividadDat = new ActividadDat();
        }


        public void InsertActividad(Actividad objActividad)
        {
            //registro del docente en la tabla
            objActividadDat.InserActividad(objActividad);
           
        }


        public bool LeerActividad(Actividad objActividad)
        {
            return objActividadDat.SelectActividad(objActividad);
        }

        public DataSet LeerActividadds()
        {
            return objActividadDat.SelectActividadds();
        }


    }
}
