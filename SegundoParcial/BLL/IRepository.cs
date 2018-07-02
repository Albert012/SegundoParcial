using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Linq.Expressions;

namespace SegundoParcial.BLL
{
    public interface IRepository<A> where A : class
    {
        bool Guardar(A entity);
        bool Modificar(A entity);
        bool Eliminar(int id);
        A Buscar(int id);
        List<A> GetList(Expression<Func<A, bool>> expression);

    }
}
