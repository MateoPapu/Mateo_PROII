using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA04.dominio
{
    internal class DetalleOrden
    {
        public Material oMaterial { get; set; }
        public int Cantidad { get; set; }
        public DetalleOrden(Material material, int cantidad)
        {
            oMaterial = material;
            Cantidad = cantidad;
        }
    }
}
