using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA04.datos
{
    public class HelperDao
    {
        private static HelperDao instancia;
        private SqlConnection conexion;
        private HelperDao()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=db_ordenes;Integrated Security=True";
        }
        //Singleton
        public static HelperDao ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new HelperDao();
            return instancia;
        }
        public DataTable Consultar(string nombreSP)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand(nombreSP, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }
        public SqlConnection ObtenerConexion()
        {
            return this.conexion;
        }
    }
}
