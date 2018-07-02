using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SegundoParcial.Entidades
{
    public class Mantenimientos
    {
        public int MantenimientoId { get; set; }
        public DateTime Fecha { get; set; }
        public Decimal Total { get; set; }

        public virtual ICollection<MantenimientosDetalle> Detalle { get; set; }

        public Mantenimientos()
        {
            this.Detalle = new List<MantenimientosDetalle>();
        }

        public void AgregarDetalle(int Id, int MantenimientoId, int VehiculoId, int Cantidad, decimal Precio, decimal Importe)
        {
            this.Detalle.Add(new MantenimientosDetalle(Id,MantenimientoId, VehiculoId, Cantidad, Precio, Importe));
        }

        

    }
}
