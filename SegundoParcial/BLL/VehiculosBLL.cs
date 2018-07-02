using SegundoParcial.DAL;
using SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SegundoParcial.BLL
{
    public class VehiculosBLL
    {
        public static List<Vehiculos> GetList(Expression<Func<Vehiculos,bool>>expression)
        {
            List<Vehiculos> lista = new List<Vehiculos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Vehiculos.Where(expression).ToList();
            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
            
        }

    }
}
