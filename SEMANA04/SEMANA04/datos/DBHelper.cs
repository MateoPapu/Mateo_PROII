using SEMANA04.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA04.datos
{
    internal class DBHelper
    {
        SqlConnection conexion = null;
        SqlCommand comando = null;
        public DBHelper()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=db_ordenes;Integrated Security=True";
        }
        public DataTable Consultar(string consultaSP)
        {
            DataTable dt = new DataTable();
            ConectarBD();
            comando = new SqlCommand(consultaSP,conexion);
            dt.Load(comando.ExecuteReader());
            DesconectarBD();
            return dt;
        }
        public bool ConfirmarOrden(OrdenRetiro orden)
        {
            bool resultado = true;
            SqlTransaction t = null;
            try
            {
                ConectarBD();
                t = conexion.BeginTransaction();
                comando = new SqlCommand("SP_INSERTAR_ORDEN", conexion, t);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@responsable", orden.Responsable);
                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@nro";
                parametro.SqlValue = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parametro);
                comando.ExecuteNonQuery();
                int nro = (int)parametro.Value;
                SqlCommand cmdDetalle = null;
                int nroDetalle = 1;
                foreach (DetalleOrden detOrd in orden.LDetalles)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLES", conexion, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@nro_orden", nro);
                    cmdDetalle.Parameters.AddWithValue("@detalle", nroDetalle);
                    cmdDetalle.Parameters.AddWithValue("@codigo", detOrd.oMaterial.Codigo);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", detOrd.Cantidad);
                    cmdDetalle.ExecuteNonQuery();
                    nroDetalle++;
                }
                t.Commit();
            }
            catch
            {
                if (t != null) 
                    t.Rollback();
                resultado = false;
            }
            finally
            {
                if (conexion != null) DesconectarBD();
            }
            return resultado;
        }
        private void ConectarBD()
        {
            conexion.Open();
        }
        private void DesconectarBD()
        {
            conexion.Close();
        }
    }
}
