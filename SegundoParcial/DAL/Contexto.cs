using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace SegundoParcial.DAL
{
    public class Contexto:DbContext
    {


        public Contexto():base("ConStr")
        {
                
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
