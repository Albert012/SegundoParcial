using SegundoParcial.DAL;
using SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SegundoParcial.BLL
{
    public class MantenimientosBLL
    {

        public static bool Guardar(Mantenimientos mantenimiento)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.Mantenimientos.Add(mantenimiento) != null)
                {
                    foreach (var item in mantenimiento.Detalle)
                    {
                        contexto.Vehiculos.Find(item.VehiculoId).Mantenimiento += item.Cantidad;
                    }
                    contexto.SaveChanges();
                    paso = true;
                }

            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Mantenimientos mantenimiento)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
               

            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }




            return paso;
        }


        public static bool Eliminar(int id)
        {
            bool paso = false;

            return paso;
        }

        public static MantenimientosDetalle Buscar(int id)
        {

        }


        public static List<MantenimientosDetalle> GetList(Expression<Func<MantenimientosDetalle,bool>>expression)
        {

        }





    }
}
