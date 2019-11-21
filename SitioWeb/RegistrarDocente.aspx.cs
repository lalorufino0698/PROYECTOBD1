using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using localhost;
using System.Data;
using System.Drawing;
public partial class RegistrarDocente : System.Web.UI.Page
{
    Docente objDocente;
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

    public void mjeRegistrar(Docente objDocente)
    {
        switch (objDocente.estado)
        {
            case 99:
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('" + "DOCENTE [" + objDocente.VNOMBRE_DOCENTE + "] REGISTRADO CON EXITO" + "');", true);
                break;
            case 22: // asunto duplicado
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('" + "DOCENTE [" + objDocente.ICOD_DOCENTE+ "] NO PROCESADO" + "');", true);
                break;

            default:
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('" + "-----?????--------" + "');", true);

                break;

        }
    }

    protected void btnRegistrar_Click(object sender, EventArgs e)
    {
        if (txtNombre.Text.Equals(""))
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('" + "El campo Nombre docente esta vacio" + "');", true);
            return;
        }
        if (txtApellidoPaterno.Text.Equals(""))
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('" + "El campo Apellido  paterno se encuentra vacio" + "');", true);
            return;
        }
        if (txtApellidoMaterno.Text.Equals(""))
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('" + "El campo Apellido Materno paterno se encuentra vacio" + "');", true);
            return;
        }
        if (txtGrado.Text.Equals(""))
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "alert", "alert('" + "El campo grado se encuentra vacio" + "');", true);
            return;
        }

        objDocente = new Docente();
        objDocente.VNOMBRE_DOCENTE = txtNombre.Text;
        objDocente.VAPATERNO_DOCENTE = txtApellidoPaterno.Text;
        objDocente.VAMATERNO_DOCENTE = txtNombre.Text;
        objDocente.FK_ICOD_CARGO = int.Parse(txtGrado.Text);

        objDocente = proxy.WebRegistrarDocente(objDocente);
        mjeRegistrar(objDocente);

    }

    protected void btnListar_Click(object sender, EventArgs e)
    {
        DataSet dsDocente = proxy.WebLeerDocentes();
        GridLis.DataSource = dsDocente.Tables[0];
        GridLis.DataBind();
    }

    protected void btnBorrar_Click(object sender, EventArgs e)
    {
        txtNombre.Text = "";
        txtApellidoPaterno.Text = "";
        txtApellidoMaterno.Text = "";
        txtGrado.Text = "";

    }
}