﻿using SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace SegundoParcial.DAL
{
    public class Contexto:DbContext
    {
        public DbSet<Vehiculos> Vehiculos { get; set; }
        public DbSet<Mantenimientos> Mantenimientos { get; set; }
        

        public Contexto():base("ConStr")
        {
                
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
