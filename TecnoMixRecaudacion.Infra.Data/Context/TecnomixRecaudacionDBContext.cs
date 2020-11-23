using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TecnomixRecaudacion.Dominio.Modelos;

namespace TecnoMixRecaudacion.Infra.Data.Context
{
    public class TecnomixRecaudacionDBContext:DbContext
    {
        public TecnomixRecaudacionDBContext(DbContextOptions options):base(options)
        {
            
        }

       // public  DbSet<Ficha> Fichas { get; set; }
        public DbSet<Zona> Zona { get; set; }
    }
}
