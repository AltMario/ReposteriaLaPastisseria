using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class WebLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    CapaNegocios.ClaseUsuario objUsuario = new CapaNegocios.ClaseUsuario();



  

    protected void btnlogin_Click(object sender, EventArgs e)
    {
        DataTable dt = objUsuario.logear(txtuser.Text,txtpass.Text);
        if(dt.Rows.Count>0)
        {

            string user = "";
            string nivel = "";



            user = dt.Rows[0][1].ToString();
            nivel = dt.Rows[0][3].ToString();

            string pagina = "WebProductos.aspx";
            string cad1 = "var1=" + user; string cad2 = "var2=" + nivel;

            if (user != "")
            {
                Response.Redirect(pagina + "?" + cad1 + "&" + cad2);

            }

        }
    }
}