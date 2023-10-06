using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SEMANA04.datos.interfaz;
using SEMANA04.dominio;

namespace SEMANA04.datos.implementacion
{
    public class OrdenRetiroDao : IOrdenRetiroDao
    {
        public bool Crear(OrdenRetiro oOrdenRetiro)
        {
            bool resultado = true;
            SqlConnection conexion = HelperDao.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand("SP_INSERTAR_ORDEN", conexion, t);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@responsable", oOrdenRetiro.Responsable);
                SqlParameter parametro = new SqlParameter("@nro", SqlDbType.Int);
                parametro.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parametro);
                comando.ExecuteNonQuery();
                int nro = (int)parametro.Value;
                int nroDetalle = 1;
                SqlCommand cmdDetalle = null;
                foreach (DetalleOrden dO in oOrdenRetiro.LDetalles)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLES", conexion, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@nro_orden", nro);
                    cmdDetalle.Parameters.AddWithValue("@detalle", nroDetalle);
                    cmdDetalle.Parameters.AddWithValue("@codigo", dO.oMaterial.Codigo);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", dO.Cantidad);
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
                if (conexion != null) conexion.Close();
            }
            return resultado;
        }
        public OrdenRetiro ObtenerOrdenPNumero(int numero)
        {
            throw new NotImplementedException();
        }
        public void Actualizar(OrdenRetiro oOrdenRetiro)
        {
            throw new NotImplementedException();
        }       
        public int Eliminar(int oOrdenRetiro)
        {
            throw new NotImplementedException();
        }        
        public List<OrdenRetiro> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
        public List<Material> ObtenerMaterial()
        {
            List<Material> listMaterial = new List<Material>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_MATERIALES");
            // Mapeo
            foreach (DataRow fila in tabla.Rows)
            {
                int codigo = int.Parse(fila["codigo"].ToString());
                string nombre = fila["nombre"].ToString();
                double stock = double.Parse(fila["stock"].ToString());
                Material material = new Material(codigo,nombre,stock);
                listMaterial.Add(material);
            }
            return listMaterial;
        }
    }
}
