using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CapaNegocios
{
    public class ClaseProducto :CapaDatos.ClaseABD
    {

        public DataTable traerProductos()
        {
            string sql = "select  p.idProducto ,p.Nombre, p.Descripcion ,p.cant,p.PrecioUnitario, t.idTamaño,t.Tamaño,t.Descripcion,tp.idTipoProducto,tp.Descripcion from Producto p inner join Tamaño t on p.idTamaño = t.idTamaño inner join Tipo_Producto as tp on p.idTipoProducto = tp.idTipoProducto";
            return TraerDatos(sql);
        }
        public DataTable buscarInicio(string n)
        {
            n = "'" + n + "%'";
            string sql = "select  p.idProducto ,p.Nombre as Torta , p.Descripcion as Contenido ,p.cant as Unidades ,p.PrecioUnitario Precio, t.idTamaño,t.Tamaño,t.Descripcion Cantidad,tp.idTipoProducto,tp.Descripcion Categoria from Producto p inner join Tamaño t on p.idTamaño = t.idTamaño inner join Tipo_Producto as tp on p.idTipoProducto = tp.idTipoProducto where p.Nombre like" + n;
            return TraerDatos(sql);
        }
        public string[] vec = new string[7];
        public int insertarProducto()
        {
            string sql = "insert into Producto values ('#v1#','#v2#','#v3#','#v4#','#v5#','#v6#')";
            sql = sql.Replace("#v1#",vec[1]);
            sql = sql.Replace("#v2#", vec[2]);
            sql = sql.Replace("#v3#", vec[3]);
            sql = sql.Replace("#v4#", vec[4]);
            sql = sql.Replace("#v5#", vec[5]);
            sql = sql.Replace("#v6#", vec[6]);
            return modificar(sql);
        }
        public int modificarProducto()
        {
            string sql = "update Producto set Nombre='#v1#',Descripcion='#v2#', idTamaño= '#v3#', idTipoProducto='#v4#',cant='#v5#',PrecioUnitario='#v6#' where idProducto='#v0#'";
            sql = sql.Replace("#v0#", vec[0]);
            sql = sql.Replace("#v1#", vec[1]);
            sql = sql.Replace("#v2#", vec[2]);
            sql = sql.Replace("#v3#", vec[3]);
            sql = sql.Replace("#v4#", vec[4]);
            sql = sql.Replace("#v5#", vec[5].Replace(",", "."));
            sql = sql.Replace("#v6#", vec[6].Replace(",", "."));
            return modificar(sql);
        }
        public int eliminarProducto()
        {
            string sql = " delete Producto where idProducto='#v0#'";
            sql = sql.Replace("#v0#", vec[0]);
           
            return modificar(sql);
        }
    }
}
