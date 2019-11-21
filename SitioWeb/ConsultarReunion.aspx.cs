using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

public partial class ConsultarReunion : System.Web.UI.Page
{
    enum Estado { Buscar, Mostra }
    Estado estado;
    Reunion objReunion;
    ReunionNeg objReunionNeg = new ReunionNeg();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            estado = Estado.Buscar;
            Session["vEstado"] = estado;
            // ocultarCliente();
            msjeInicial();

            txtFecha.Enabled = false;
            txtDHENT.Enabled = false;
            txtDHSAL.Enabled = false;
            txtLugar.Enabled = false;
            txtcodDocente.Enabled = false;


        }
    }

    public void msjeInicial()
    {
        lblMensaje.Text = "Ingrese codigo de reunion y pulse Consultar";


    }

    private void verReunion()
    {
        txtCodigoReunion.Enabled = true;
        txtFecha.Enabled = true;
        txtDHENT.Enabled = true;
        txtDHSAL.Enabled = true;
        txtLugar.Enabled = true;
        txtcodDocente.Enabled = true;

    }

    private void CargarReunion()
    {
        txtFecha.Text = Convert.ToString(objReunion.DFEC_REUNION);
        txtDHENT.Text = Convert.ToString(objReunion.DHENT_REUNION);
        txtDHSAL.Text = Convert.ToString(objReunion.DHSAL_REUNION);
        txtLugar.Text = Convert.ToString(objReunion.VLUGAR_REUNION);
        txtcodDocente.Text = Convert.ToString(objReunion.FK_ICOD_DOCENTE);

    }

    private void mostrarMjeConsultar(Reunion objReunion)
    {
        switch (objReunion.estado)
        {
            case 1:
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('" + "REUNION  [" + objReunion.ICOD_REUNION + "] NO EXISTE" + "');", true);
                break;
            case 99:
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('" + "REUNION [" + objReunion.ICOD_REUNION + "] ENCONTRADO CON EXITO" + "');", true);
                break;
            default:
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('" + "--------????------" + "');", true);

                break;
        }
    }

    protected void btnConsultar_Click(object sender, EventArgs e)
    {
        objReunion = new Reunion();
        objReunion.ICOD_REUNION = int.Parse(txtCodigoReunion.Text);
        objReunionNeg.LeerReunion(objReunion);
        mostrarMjeConsultar(objReunion);

        if (objReunion.estado == 99)
        {
            CargarReunion();
            verReunion();
        }
    }

    protected void btnBorrar_Click(object sender, EventArgs e)
    {
        txtCodigoReunion.Text = "";
        txtFecha.Text = "";
        txtDHENT.Text = "";
        txtDHSAL.Text = "";
        txtCodigoReunion.Text = "";

    }

    protected void btnSalir_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}