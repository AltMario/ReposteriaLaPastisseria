using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CapaNegocios
{
     public class ClaseRol:CapaDatos.ClaseABD
    {
        public DataTable traerRol()
        {
            string sql = "select *from Rol";
             return TraerDatos(sql);
        }


    
    }
}
