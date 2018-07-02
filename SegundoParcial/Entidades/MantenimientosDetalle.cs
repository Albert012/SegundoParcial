using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SegundoParcial.Entidades
{
    public class MantenimientosDetalle
    {
        [Key]

        public int Id { get; set; }
        public int MantenimientoId { get; set; }
        public int VehiculoId { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }
        

        [ForeignKey("MantenimientoId")]
        public virtual Mantenimientos Mantenimiento { get; set; }

        [ForeignKey("VehiculoId")]
        public virtual Vehiculos Vehviculo { get; set; }


        public MantenimientosDetalle()
        {
            Id = 0;
            MantenimientoId = 0;
            VehiculoId = 0;
        }

        public MantenimientosDetalle(int id, int mantenimientoId, int vehiculoId, int cantidad, decimal precio, decimal importe)
        {
            Id = id;
            MantenimientoId = mantenimientoId;
            VehiculoId = vehiculoId;
            Precio = precio;
            Importe = importe;
        }

    }
}
