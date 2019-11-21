using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using localhost;
using System.Data;
using System.Drawing;

public partial class RegistrarActividad : System.Web.UI.Page
{


    Actividad objActividad;
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

    public void mjeRegistrar(Actividad objActividad)
    {
        ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('" + "ACTIVIDAD REGISTRADO CON EXITO" + "');", true);
    }
    protected void btnRegistrar_Click(object sender, EventArgs e)
    {
        if (txtVDESC_ACTIVIDAD.Text.Equals(""))
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('" + "El campo DFECH esta vacio" + "');", true);
            return;
        }
        if (txtDFEC_ACTIVIDAD.Text.Equals(""))
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('" + "El campo DHENT se encuentra vacio" + "');", true);
            return;
        }
        

        objActividad = new Actividad();
        objActividad.VDESC_ACTIVIDAD = txtVDESC_ACTIVIDAD.Text;
        objActividad.DFEC_ACTIVIDAD = Convert.ToDateTime(txtDFEC_ACTIVIDAD.Text);
        

        objActividad = proxy.WebRegistrarActividad(objActividad);
        mjeRegistrar(objActividad );

    }

    protected void btnListar_Click(object sender, EventArgs e)
    {
        DataSet dsActividad = proxy.WebLeerActividadds();
        GridLis.DataSource = dsActividad.Tables[0];
        GridLis.DataBind();
    }

    protected void btnBorrar_Click(object sender, EventArgs e)
    {
        txtDFEC_ACTIVIDAD.Text = "";
        txtVDESC_ACTIVIDAD.Text = "";
    }
}