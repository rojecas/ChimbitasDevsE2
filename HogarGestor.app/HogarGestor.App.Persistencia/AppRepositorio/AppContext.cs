using Microsoft.EntityFrameworkCore;

namespace HogarGestor.App.Persistencia
{ 
    using HogarGestor.App.Dominio;

    public class AppContext : DbContext
    {
        public DbSet<Cls_Persona> ? personas {get; set;}
        public DbSet<Cls_Familiar> ? familiar {get; set;}
        public DbSet<Cls_PersonalSalud> ? pediatra {get; set;}
        public DbSet<Cls_PersonalSalud> ? nutricionista {get; set;}
        public DbSet<Cls_PatronCrecimiento> ? patronCrecimiento {get; set;}
        public DbSet<Cls_SugerenciasCuidado> ? sugerencia {get; set;}
        public DbSet<Cls_Historia> ? historia {get; set;}
        public DbSet<Cls_Beneficiario> ? beneficiarios {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocal;Initial Catalog=HogarGestor");
                optionsBuilder.UseSqlServer("Data Source=SERVTEC\\SQLEXPRESS;Initial Catalog=HogarGestor;Trusted_Connection=True");
            }
        }

    }    
}