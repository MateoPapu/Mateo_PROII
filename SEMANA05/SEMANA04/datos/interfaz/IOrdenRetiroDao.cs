using SEMANA04.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA04.datos.interfaz
{
    public interface IOrdenRetiroDao
    {
        bool Crear(OrdenRetiro oOrdenRetiro);
        OrdenRetiro ObtenerOrdenPNumero(int numero);
        void Actualizar(OrdenRetiro oOrdenRetiro);
        int Eliminar(int oOrdenRetiro);
        List<OrdenRetiro> ObtenerTodos();
        List<Material> ObtenerMaterial();
    }
}
