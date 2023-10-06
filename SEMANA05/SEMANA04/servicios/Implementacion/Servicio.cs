using SEMANA04.dominio;
using SEMANA04.servicios.Interfaz;
using SEMANA04.datos.interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEMANA04.datos.implementacion;
using SEMANA04.datos;

namespace SEMANA04.servicios.Implementacion
{
    public class Servicio : IServicio
    {
        private IOrdenRetiroDao dao;
        public Servicio(AbstractFactoryDao factoryDao)
        {
            dao = factoryDao.CrearPresupuestoDao();
        }
        public bool CrearOrdenRetiro(OrdenRetiro oOrdenRetiro)
        {
            return dao.Crear(oOrdenRetiro);
        }
        public List<Material> TraerMaterial()
        {
            return dao.ObtenerMaterial();
        }
    }
}
