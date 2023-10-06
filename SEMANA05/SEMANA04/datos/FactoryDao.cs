using SEMANA04.datos.implementacion;
using SEMANA04.datos.interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA04.datos
{
    public class FactoryDao : AbstractFactoryDao
    {
        public override IOrdenRetiroDao CrearPresupuestoDao()
        {
            return new OrdenRetiroDao();
        }
    }
}
