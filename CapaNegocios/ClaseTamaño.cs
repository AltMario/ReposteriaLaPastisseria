using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CapaNegocios
{
   public class ClaseTamaño:CapaDatos.ClaseABD
    {
       public DataTable TraerTamaño()
        {
            string sql = "select * from Tamaño";
            return TraerDatos(sql);
        }
    }
}
