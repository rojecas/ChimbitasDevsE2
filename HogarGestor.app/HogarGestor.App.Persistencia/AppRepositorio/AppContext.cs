using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HogarGestor.App.Persistencia.AppRepositorio
{
    using Microsoft.EntityFrameworkCore;
    using HogarGestor.App.Dominio;
    using HogarGestor.App.Persistencia;

    public class AppContext
    {
        public DbSet<Cls_Persona> Personas {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source=(localdb)/MSSQLLocal;Initial Catalog=HogarGestor");
            }
        }
    }
}