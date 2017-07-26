using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;


namespace CapaDatos
{
    public class ClaseABD
    {
        private OleDbConnection Conectar()
        {
            string cad = "Provider=SQLOLEDB.1;Data Source=TEMPLARIOS;Initial Catalog=bdReposteria;Integrated Security=SSPI";
            OleDbConnection obconectar = new OleDbConnection(cad);
            obconectar.Open();
            return obconectar;
        }

        protected DataTable TraerDatos(string sql)
        {
            OleDbDataAdapter adaptador = new OleDbDataAdapter(sql ,Conectar());
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }
        protected int modificar(string sql)
        {
            OleDbCommand com = new OleDbCommand(sql,Conectar());
            return com.ExecuteNonQuery();
        }
    }
}
