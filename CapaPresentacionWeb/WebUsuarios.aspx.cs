using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class WebUsuarios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Session["dtusuario"] = objusuario.buscarInicioUsuario(txtbuscar.Text);
            actualizar();
            CargarRol();
        }

    }
    CapaNegocios.ClaseUsuario objusuario = new CapaNegocios.ClaseUsuario();
    CapaNegocios.ClaseRol objrol = new CapaNegocios.ClaseRol();
    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        actualizar();
        limpiar();
    }
    void actualizar()
    {
        Session["dtusuario"] = objusuario.buscarInicioUsuario(txtbuscar.Text);
        dg_usuario.DataSource = Session["dtusuario"];
        dg_usuario.DataBind();
    }
    void limpiar()
    {
        txtusuario.Text = "";
        txtcontraseña.Text = "";
        txtbuscar.Text = "";
    }
  
    void CargarRol()
    {
        DropRol.DataSource = objrol.traerRol();
        DropRol.DataTextField = "Descripcion";
        DropRol.DataValueField = "idRol";
        DropRol.DataBind();

    }


 

    protected void dg_usuario_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void dg_usuario_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Session["idusuario"] = dg_usuario.Rows[e.RowIndex].Cells[1].Text;
        txtusuario.Text = dg_usuario.Rows[e.RowIndex].Cells[2].Text;
        txtcontraseña.Text = dg_usuario.Rows[e.RowIndex].Cells[3].Text;
        DropRol.SelectedValue = dg_usuario.Rows[e.RowIndex].Cells[4].Text;
    }

    protected void btnRegistrar_Click(object sender, EventArgs e)
    {
        objusuario.vec[1] = txtusuario.Text;
        objusuario.vec[2] = txtcontraseña.Text;
        objusuario.vec[3] = DropRol.SelectedValue;

        objusuario.insertarUsuario();
        actualizar();
        limpiar();
    }

    protected void btnactualizar_Click(object sender, EventArgs e)
    {
        objusuario.vec[0] = Session["idusuario"].ToString();
        objusuario.vec[1] = txtusuario.Text;
        objusuario.vec[2] = txtcontraseña.Text;
        objusuario.vec[3] = DropRol.SelectedValue;

        objusuario.actualizarUsuario();
        actualizar();
        limpiar();
    }

    protected void btneliminar_Click(object sender, EventArgs e)
    {
        objusuario.vec[0] = Session["idusuario"].ToString();
        

        objusuario.eliminarUsuario();
        actualizar();
        limpiar();
    }







    protected void dg_usuario_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        e.Row.Cells[1].Visible = false;
        e.Row.Cells[4].Visible = false;
       
    }

    protected void dg_usuario_DataBound(object sender, EventArgs e)
    {

    }
}