using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Core.Entities;
using Core.Entities.Seeding;

namespace Infrastructure;
public class AplicationDbContext : DbContext
{
    public AplicationDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<AreaCampus> Areas => Set<AreaCampus>();
    public DbSet<CategoriaIncidencia> Categorias => Set<CategoriaIncidencia>();
    public DbSet<EmailsTrainers> EmailsTrainer => Set<EmailsTrainers>();
    public DbSet<Hardware> Hardwares => Set<Hardware>();
    public DbSet<Incidencia> Incidencias => Set<Incidencia>();
    public DbSet<Puesto> Puestos => Set<Puesto>();
    public DbSet<Salon> Salones => Set<Salon>();
    public DbSet<Software> Softwares => Set<Software>();
    public DbSet<TelefonosTrainers> TelefonosTrainer => Set<TelefonosTrainers>();
    public DbSet<TipoHardware> TiposHardware => Set<TipoHardware>();
    public DbSet<TipoIncidencia> TiposIncidencia => Set<TipoIncidencia>();
    public DbSet<TiposEmail> TiposEmail => Set<TiposEmail>();
    public DbSet<TipoSoftware> TiposSoftware => Set<TipoSoftware>();
    public DbSet<TiposTelefono> TiposTelefono => Set<TiposTelefono>();
    public DbSet<Trainer> Trainers => Set<Trainer>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            SeedingInicail.Seed(modelBuilder);

        }
}
