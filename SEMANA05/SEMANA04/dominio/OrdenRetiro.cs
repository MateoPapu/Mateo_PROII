using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA04.dominio
{
    public class OrdenRetiro
    {
        public int NroOrden { get; set; }
        public DateTime Fecha { get; set; }
        public string Responsable { get; set; }
        public List<DetalleOrden> LDetalles { get; set; }
        public OrdenRetiro()
        {
            LDetalles = new List<DetalleOrden>();
        }
        public OrdenRetiro(int nroOrden, DateTime fecha, string responsable)
        {
            NroOrden = nroOrden;
            Fecha = fecha;
            Responsable = responsable;
        }
        public void AgregarDetalle(DetalleOrden detalle)
        {
            LDetalles.Add(detalle);
        }
        public void QuitarDetalle(int num)
        {
            LDetalles.RemoveAt(num);
        }
    }
}
