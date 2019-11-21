using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using localhost;
using System.Data;
using System.Drawing;

public partial class RegistrarReunion : System.Web.UI.Page
{

    Reunion objReunion;
    localhost.Webservice proxy = new localhost.Webservice();
    protected void Page_Load(object sender, EventArgs e)
    {
        mjeInicial();

    }

    public void mjeInicial()
    {
        lblMensaje.Text = "Complete los campos y pulse REGISTRAR";
        lblMensaje.ForeColor = Color.Blue;
    }

    public void mjeRegistrar(Reunion objReunion)
    {
        switch (objReunion.estado)
        {
            case 99:
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('" + "REUNION  REGISTRADO CON EXITO" + "');", true);
                break;
            case 22: // asunto duplicado
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('" + "REUNIOM [" + objReunion.ICOD_REUNION + "] NO PROCESADO" + "');", true);
                break;

            default:
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('" + "-------????????------------" + "');", true);

                break;

        }
    }

    protected void btnRegistrar_Click(object sender, EventArgs e)
    {
        if (txtDFEC_REUNION.Text.Equals(""))
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('" + "El campo DFECH esta vacio" + "');", true);
            return;
        }
        if (txtDHENT_REUNION.Text.Equals(""))
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('" + "El campo DHENT se encuentra vacio" + "');", true);
            return;
        }
        if (txtDHSAL_REUNION.Text.Equals(""))
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('" + "El campo DHSAL paterno se encuentra vacio" + "');", true);
            return;
        }
        if (txtVLUGAR_REUNION.Text.Equals(""))
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('" + "El campo LUGAR se encuentra vacio" + "');", true);
            return;
        }
        if (txtFK_ICOD_DOCENTE.Text.Equals(""))
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('" + "El campo IDCODIGO DOCENTE se encuentra vacio" + "');", true);
            return;
        }

        objReunion = new Reunion();
        objReunion.DFEC_REUNION= Convert.ToDateTime(txtDFEC_REUNION.Text);
        objReunion.DHENT_REUNION = Convert.ToDateTime(txtDHENT_REUNION.Text);
        objReunion.DHSAL_REUNION = Convert.ToDateTime(txtDHSAL_REUNION.Text);
        objReunion.VLUGAR_REUNION = txtVLUGAR_REUNION.Text;
        objReunion.FK_ICOD_DOCENTE = int.Parse(txtFK_ICOD_DOCENTE.Text);

        objReunion = proxy.WebRegistrarReunion(objReunion);
        mjeRegistrar(objReunion);

    }

    protected void btnListar_Click(object sender, EventArgs e)
    {
        DataSet dsReunion = proxy.WebLeerReunionds();
        GridLis.DataSource = dsReunion.Tables[0];
        GridLis.DataBind();
    }

    protected void btnBorrar_Click(object sender, EventArgs e)
    {
        txtDFEC_REUNION.Text = "";
        txtDHENT_REUNION.Text = "";
        txtDHSAL_REUNION.Text = "";
        txtVLUGAR_REUNION.Text = "";
        txtFK_ICOD_DOCENTE.Text = "";
    }
}