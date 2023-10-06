using SEMANA04.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA04.servicios.Interfaz
{
    public interface IServicio
    {
        bool CrearOrdenRetiro(OrdenRetiro oOrdenRetiro);
        List<Material> TraerMaterial();
    }
}
