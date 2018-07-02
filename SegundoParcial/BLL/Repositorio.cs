using SegundoParcial.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SegundoParcial.BLL
{
    public class Repositorio<A> : IDisposable, IRepository<A> where A : class
    {
        internal Contexto _contexto;

        public Repositorio(Contexto contexto)
        {
            _contexto = contexto;
        }

        public bool Guardar(A entity)
        {
            bool paso = false;

            try
            {
                if (_contexto.Set<A>().Add(entity) != null)
                {
                    _contexto.SaveChanges();
                    paso = true;
                }
            }
            catch
            {
                throw;
            }
            return paso;
        }

        public bool Modificar(A entity)
        {
            bool paso = false;

            try
            {
                _contexto.Entry(entity).State = EntityState.Modified;
                if (_contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
            }
            catch
            {
                throw;
            }

            return paso;
        }

        public bool Eliminar(int id)
        {
            bool paso = false;

            try
            {
                A entity = _contexto.Set<A>().Find(id);
                _contexto.Set<A>().Remove(entity);

                if (_contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                _contexto.Dispose();
            }
            catch
            {
                throw;
            }

            return paso;
        }

        public A Buscar(int id)
        {
            A entity;

            try
            {
                entity = _contexto.Set<A>().Find(id);
            }
            catch
            {
                throw;
            }
            return entity;
        }

        public List<A> GetList(Expression<Func<A,bool>>expression)
        {
            List<A> list = new List<A>();

            try
            {
                list = _contexto.Set<A>().Where(expression).ToList();
            }
            catch
            {
                throw;
            }
            return list;
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }



    }
}
