using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

public partial class ConsultarDocente : System.Web.UI.Page
{

    enum Estado { Buscar, Mostra }
    Estado estado;
    Docente objDocente;
    DocenteNeg objDocenteNeg = new DocenteNeg();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            estado = Estado.Buscar;
            Session["vEstado"] = estado;
            // ocultarCliente();
            msjeInicial();

            txtNombre.Enabled = false;
            txtApellidosPaterno.Enabled = false;
            txtApellidoMaterno.Enabled = false;
            txtGrado.Enabled = false;


        }
    }

    public void msjeInicial()
    {
        lblMensaje.Text = "Ingrese codigo de docente y pulse Consultar";


    }

    private void verDocente()
    {
        txtDocente.Enabled = true;
        txtNombre.Enabled = true;
        txtApellidosPaterno.Enabled = true;
        txtApellidoMaterno.Enabled = true;
        txtGrado.Enabled = true;
    }

    private void CargarDocente()
    {
        txtNombre.Text = objDocente.VNOMBRE_DOCENTE;
        txtApellidosPaterno.Text = objDocente.VAPATERNO_DOCENTE;
        txtApellidoMaterno.Text = objDocente.VAMATERNO_DOCENTE;
        txtGrado.Text = Convert.ToString(objDocente.FK_ICOD_CARGO);

    }

    private void mostrarMjeConsultar(Docente objDocente)
    {
        switch (objDocente.estado)
        {
            case 1:
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('" + "DOCENTE [" + objDocente.ICOD_DOCENTE + "] NO EXISTE" + "');", true);
                break;
            case 99:
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('" + "DOCENTE [" + objDocente.ICOD_DOCENTE + "] ENCONTRADO" + "');", true);
                break;
            default:
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('" + "--------????------" + "');", true);

                break;
        }
    }


    protected void btnConsultar_Click(object sender, EventArgs e)
    {
        objDocente = new Docente();
        objDocente.ICOD_DOCENTE = int.Parse(txtDocente.Text);
        objDocenteNeg.LeerDocente(objDocente);
        mostrarMjeConsultar(objDocente);

        if (objDocente.estado == 99)
        {
            CargarDocente();
            verDocente();
        }

    }

    protected void btnBorrar_Click(object sender, EventArgs e)
    {
        txtDocente.Text = "";
        txtNombre.Text = "";
        txtApellidosPaterno.Text = "";
        txtApellidoMaterno.Text = "";
        txtGrado.Text = "";
    }

    protected void btnSalir_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}