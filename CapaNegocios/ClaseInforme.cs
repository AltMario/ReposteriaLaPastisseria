using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CapaNegocios
{
    public class ClaseInforme:CapaDatos.ClaseABD
    {
        public DataTable traerRol()
        {
            string sql = "select   nombre , cant from producto";
            return TraerDatos(sql);
        }
    }
}
