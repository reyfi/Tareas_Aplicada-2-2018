﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RegistroCoArticulos.Entidades;
using System.Data.Entity;

namespace RegistroCoArticulos.DAL
{
    public class Contexto : DbContext 
    {
        public DbSet<Articulos> Articulos{ get; set; }


        public Contexto() : base("ConStr")
        {

        }
    }
}
