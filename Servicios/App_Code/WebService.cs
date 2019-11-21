using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Dominio;
using Negocio;
using GestionDatos;
using System.Data;

/// <summary>
/// Descripción breve de WebService
/// </summary>
[WebService(Namespace = "http://www.edu.pe/localhost", Name = "Webservice", Description = "Servicioweb_ProyectoBD1")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.
public class WebService : System.Web.Services.WebService
{
    Docente objDocente;
    DocenteNeg objdocenteNeg = new DocenteNeg();


    //REUNION
    Reunion objReunion;
    ReunionNeg objReunionNeg = new ReunionNeg();


    //actividad
    Actividad objActividad;
    ActividadNeg objActividadNeg = new ActividadNeg();
    public WebService()
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }


    //DOCENTE
    [WebMethod]
    public Docente WebRegistrarDocente(Docente objDocente)
    {
        objdocenteNeg.RegistrarDocente(objDocente);
        return objDocente;
    }
    [WebMethod]
    public Docente WebActualizarDocente(Docente objDocente)
    {
        objdocenteNeg.ActualizarDocente(objDocente);
        return objDocente;
    }
    [WebMethod]
    public Docente WebEliminarDocente(Docente objDocente)
    {
        objdocenteNeg.EliminarDocente(objDocente);
        return objDocente;
    }
    [WebMethod]
    public Docente WebLeerDocente(Docente objDocente)
    {
        objdocenteNeg.LeerDocente(objDocente);
        return objDocente;
    }
    [WebMethod]
    public DataSet WebLeerDocentes()
    {
        return objdocenteNeg.LeerDocentes();
    }


    //REUNION


    [WebMethod]
    public Reunion WebRegistrarReunion(Reunion objReunion)
    {
        objReunionNeg.InsertReunion(objReunion);
        return objReunion;
    }
   
    [WebMethod]
    public Reunion WebLeerReunion(Reunion objReunion)
    {
        objReunionNeg.LeerReunion(objReunion);
        return objReunion;
    }
    [WebMethod]
    public DataSet WebLeerReunionds()
    {
        return objReunionNeg.LeerReunionds();
    }


    //actividad


    [WebMethod]
    public Actividad WebRegistrarActividad(Actividad objActividad)
    {
        objActividadNeg.InsertActividad(objActividad);
        return objActividad;
    }

    [WebMethod]
    public Actividad WebLeerActividad(Actividad objActividad)
    {
        objActividadNeg.LeerActividad(objActividad);
        return objActividad;
    }
    [WebMethod]
    public DataSet WebLeerActividadds()
    {
        return objActividadNeg.LeerActividadds();
    }


}
