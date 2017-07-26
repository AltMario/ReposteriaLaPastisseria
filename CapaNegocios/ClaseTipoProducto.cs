using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CapaNegocios
{
   public class ClaseTipoProducto:CapaDatos.ClaseABD
    {
        public DataTable traerTipoProductos()
        {
            string sql = "select *from Tipo_Producto";
            return TraerDatos(sql);
        }
    }
}
