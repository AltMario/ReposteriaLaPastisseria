using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CapaNegocios
{
    public class ClaseUsuario:CapaDatos.ClaseABD
    {
        public DataTable buscarInicioUsuario(string n)
        {
            n = "'" + n + "%'";
            string sql = "select u.idUsuario, u.uss as Usuario ,u.pass as Contraseña ,u.idRol ,r.Descripcion as Rol from Usuario as u inner join Rol as r on u.idRol=r.idRol where u.uss  like " + n;
            return TraerDatos(sql);
        }
        public string[] vec = new string[4];
        public int insertarUsuario()
         
        {
            string sql = "   insert into Usuario values ('#v1#','#v2#','#v3#')";
            sql = sql.Replace("#v1#", vec[1]);
            sql = sql.Replace("#v2#", vec[2]);
            sql = sql.Replace("#v3#", vec[3]);
           
            return modificar(sql);
        }
      

        public int actualizarUsuario()

        {
            string sql = "  update Usuario set uss = '#v1#', pass = '#v2#', idRol = '#v3#' where idUsuario = '#v0#'  ";
            sql = sql.Replace("#v0#", vec[0]);
            sql = sql.Replace("#v1#", vec[1]);
            sql = sql.Replace("#v2#", vec[2]);
            sql = sql.Replace("#v3#", vec[3]);

            return modificar(sql);
        }
        public int eliminarUsuario()

        {
            string sql = " delete Usuario where idUsuario = '#v0#'";
            sql = sql.Replace("#v0#", vec[0]);

            return modificar(sql);
        }
        public DataTable logear(string a, string b)
        {
            string sql = "select * from Usuario  where Usuario.uss='#nombre#' and Usuario.pass='#pasword#'";
            sql = sql.Replace("#nombre#", a);
            sql = sql.Replace("#pasword#", b);
            return TraerDatos(sql);
        }

    }
}
