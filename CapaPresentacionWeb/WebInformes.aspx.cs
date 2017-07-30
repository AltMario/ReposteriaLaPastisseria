using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

public partial class WebInformes : System.Web.UI.Page
{
    CapaNegocios.ClaseInforme objinfo = new CapaNegocios.ClaseInforme();
    protected void Page_Load(object sender, EventArgs e)
    {
        Chart2.DataSource = objinfo.traerRol();

     

        //Cargo consulta para llenado de grafico

        Chart2.Series["Series1"].LegendText= "Cantidad de Productos";
        Chart2.Series["Series1"].XValueMember = "Nombre";
        Chart2.Series["Series1"].YValueMembers = "cant";
        this.Chart2.DataBind();



    }
}