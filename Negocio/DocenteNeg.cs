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
   public  class DocenteNeg
    {
        DocenteDat objDocenteDat;


        public DocenteNeg()
        {
            objDocenteDat = new DocenteDat();
        }

        public void RegistrarDocente(Docente objDocente)
        {
            bool correcto = true;

            //Nombre: entre 1 caracter significativo y 50; error = 1
            string sNombres = objDocente.VNOMBRE_DOCENTE.Trim();
            correcto = sNombres.Length > 0 && sNombres.Length < 51;
            if (!correcto)
            {
                objDocente.estado = 1;
                return;
            }
            objDocente.VNOMBRE_DOCENTE = sNombres;
            //apellidosPaterno: entre 1 caracter significativo y 50; error = 2
            string sApellidosPaterno = objDocente.VAPATERNO_DOCENTE.Trim();
            correcto = sApellidosPaterno.Length > 0 && sApellidosPaterno.Length < 51;
            if (!correcto)
            {
                objDocente.estado = 2;
                return;
            }
            objDocente.VAPATERNO_DOCENTE = sApellidosPaterno;

            //apellidosMaterno: entre 1 caracter significativo y 50; error = 3
            string sApellidosMaterno = objDocente.VAMATERNO_DOCENTE.Trim();
            correcto = sApellidosMaterno.Length > 0 && sApellidosMaterno.Length < 51;
            if (!correcto)
            {
                objDocente.estado = 3;
                return;
            }
            objDocente.VAMATERNO_DOCENTE = sApellidosMaterno;

            //codigo de GRADO digitos significativos: entre 0 a mas; error = 4
            int nCodigo;
            try
            {
                nCodigo = objDocente.FK_ICOD_CARGO;
                correcto = nCodigo > 0;
            }
            catch
            {
                correcto = false;
            }
            if (!correcto)
            {
                objDocente.estado = 4;
                return;
            }


            //Verificar duplicidad: error = 22
            Docente objDocenteT = new Docente();
            objDocenteT.ICOD_DOCENTE= objDocente.ICOD_DOCENTE;
            correcto = !objDocenteDat.SelectDocente(objDocenteT);
            if (!correcto)
            {
                objDocente.estado = 22;
                return;
            }
            //registro del docente en la tabla
            objDocenteDat.InsertDocente(objDocente);
            objDocente.estado = 99;
        }



        //Actualizar Docente

        public void ActualizarDocente(Docente objDocente)
        {

            bool correcto = true;
            //Nombre: entre 1 caracter significativo y 50; error = 1
            string sNombres = objDocente.VNOMBRE_DOCENTE.Trim();
            correcto = sNombres.Length > 0 && sNombres.Length < 51;
            if (!correcto)
            {
                objDocente.estado = 1;
                return;
            }
            objDocente.VNOMBRE_DOCENTE = sNombres;
            //apellidosPaterno: entre 1 caracter significativo y 50; error = 2
            string sApellidosPaterno = objDocente.VAPATERNO_DOCENTE.Trim();
            correcto = sApellidosPaterno.Length > 0 && sApellidosPaterno.Length < 51;
            if (!correcto)
            {
                objDocente.estado = 2;
                return;
            }
            objDocente.VAPATERNO_DOCENTE = sApellidosPaterno;

            //apellidosMaterno: entre 1 caracter significativo y 50; error = 3
            string sApellidosMaterno = objDocente.VAMATERNO_DOCENTE.Trim();
            correcto = sApellidosMaterno.Length > 0 && sApellidosMaterno.Length < 51;
            if (!correcto)
            {
                objDocente.estado = 3;
                return;
            }
            objDocente.VAMATERNO_DOCENTE = sApellidosMaterno;

            //codigo de GRADO digitos significativos: entre 0 a mas; error = 4
            int nCodigo;
            try
            {
                nCodigo = objDocente.FK_ICOD_CARGO;
                correcto = nCodigo > 0;
            }
            catch
            {
                correcto = false;
            }
            if (!correcto)
            {
                objDocente.estado = 4;
                return;
            }

            //registro de actualizacion de DOCENTE en tabla
            objDocenteDat.UpdateDocente(objDocente);
            objDocente.estado = 99;
        }


        public void EliminarDocente(Docente objDocente)
        {
            bool correcto = true;
            //Verificar que Alumno exista, error = 1
            Docente objDocenteT = new Docente();
            objDocenteT.ICOD_DOCENTE = objDocente.ICOD_DOCENTE;
            correcto = objDocenteDat.SelectDocente(objDocenteT);

            if (!correcto)
            {
                objDocente.estado = 1;
                return;
            }


            //eliminacion de Docente en tabla
            objDocenteDat.DeleteDocente(objDocente);
            objDocente.estado = 99;
        }


        public bool LeerDocente(Docente objCotizacion)
        {
            return objDocenteDat.SelectDocente(objCotizacion);
        }

        public DataSet LeerDocentes()
        {
            return objDocenteDat.SelectDocenteds();
        }



    }
}
