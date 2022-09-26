using Microsoft.EntityFrameworkCore;
using HogarGestor.App.Dominio;

namespace HogarGestor.App.Persistencia;
public class AppContext : DbContext
{
    public DbSet<Cls_Persona>? personas { get; set; }
    public DbSet<Cls_Familiar>? familiares { get; set; }
    //public DbSet<Cls_PersonalSalud>? pediatra { get; set; }
    //public DbSet<Cls_PersonalSalud>? nutricionista { get; set; }
    public DbSet<Cls_PersonalSalud>? personasSalud { get; set; }
    public DbSet<Cls_PatronCrecimiento>? patronesDeCrecimiento { get; set; }
    public DbSet<Cls_SugerenciasCuidado>? sugerencias { get; set; }
    public DbSet<Cls_Historia>? historias { get; set; }
    public DbSet<Cls_Beneficiario>? beneficiarios { get; set; }
    public AppContext(DbContextOptions<AppContext> options) : base(options) { } // se debe comentar esta linea si se va a hacer una migracion a la BD
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Data Source=SERVTEC\\SQLEXPRESS;Initial Catalog=HogarGestor;Trusted_Connection=True");
        }
    }
}
