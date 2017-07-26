using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebProductos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Session["dtproducto"] = ObjProducto.buscarInicio(txtbuscar.Text);
            cargarTipoProducto();
            CargarTamaño();
            actualizar();
        }
        
    }

    CapaNegocios.ClaseProducto ObjProducto = new CapaNegocios.ClaseProducto();
    CapaNegocios.ClaseTipoProducto objTipoProducto = new CapaNegocios.ClaseTipoProducto();
    CapaNegocios.ClaseTamaño objTamaño = new CapaNegocios.ClaseTamaño();
    protected void g_Producto_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    void CargarTamaño()
    {
        DropTamaño.DataSource = objTamaño.TraerTamaño();
        DropTamaño.DataTextField = "Tamaño";
        DropTamaño.DataValueField = "idTamaño";
        DropTamaño.DataBind();

    }
    void cargarTipoProducto()
    {
        DropCategoria.DataSource = objTipoProducto.traerTipoProductos();
        DropCategoria.DataTextField = "Descripcion";
        DropCategoria.DataValueField = "idTipoProducto";
        DropCategoria.DataBind();
    }

    protected void g_Producto_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

        Session["idproducto"] = g_Producto.Rows[e.RowIndex].Cells[1].Text;
        txtNombre.Text = g_Producto.Rows[e.RowIndex].Cells[2].Text;
        txtDescripcion.Text = g_Producto.Rows[e.RowIndex].Cells[3].Text;
        txtCantidad.Text = g_Producto.Rows[e.RowIndex].Cells[4].Text;
        txtPrecio.Text = g_Producto.Rows[e.RowIndex].Cells[5].Text;
        DropCategoria.SelectedValue = g_Producto.Rows[e.RowIndex].Cells[9].Text;
        DropTamaño.SelectedValue= g_Producto.Rows[e.RowIndex].Cells[6].Text;
    }
    protected void DropTamaño_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

 

   

 
    void actualizar()
    {

        Session["dtproducto"] = ObjProducto.buscarInicio(txtbuscar.Text);
        g_Producto.DataSource = Session["dtproducto"];
        g_Producto.DataBind();
    }
    void limpiar()
    {
        txtbuscar.Text = "";
        txtNombre.Text = "";
        txtDescripcion.Text = "";
        txtCantidad.Text = "";
        txtPrecio.Text = "";
    }


    protected void g_Producto_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        e.Row.Cells[1].Visible = false;
        e.Row.Cells[6].Visible = false;
        e.Row.Cells[9].Visible = false;
    }

    protected void btnsearch_Click(object sender, EventArgs e)
    {
        actualizar();
    }

    protected void btnadd_Click(object sender, EventArgs e)
    {
        ObjProducto.vec[1] = txtNombre.Text;
        ObjProducto.vec[2] = txtDescripcion.Text;
        ObjProducto.vec[3] = DropTamaño.SelectedValue;
        ObjProducto.vec[4] = DropCategoria.SelectedValue;
        ObjProducto.vec[5] = txtCantidad.Text;
        ObjProducto.vec[6] = txtPrecio.Text;

        ObjProducto.insertarProducto();
        actualizar();
        limpiar();
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        ObjProducto.vec[0] = Session["idproducto"].ToString();
        ObjProducto.vec[1] = txtNombre.Text;
        ObjProducto.vec[2] = txtDescripcion.Text;
        ObjProducto.vec[3] = DropTamaño.SelectedValue;
        ObjProducto.vec[4] = DropCategoria.SelectedValue;
        ObjProducto.vec[5] = txtCantidad.Text;
        ObjProducto.vec[6] = txtPrecio.Text;

        ObjProducto.modificarProducto();
        actualizar();
        limpiar();
    }

    protected void btndelete_Click(object sender, EventArgs e)
    {
        ObjProducto.vec[0] = Session["idproducto"].ToString();
        ObjProducto.eliminarProducto();
        limpiar();
        actualizar();
    }
}