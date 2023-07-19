using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Configurations
{
    public class IncidenciasConfig : IEntityTypeConfiguration<Incidencia>
    {
        public void Configure(EntityTypeBuilder<Incidencia> builder)
        {
             builder.HasOne(x => x.TipoIncidencia)
            .WithMany(x =>x.Incidencias)
            .HasForeignKey(x => x.IdTipoIncidencia)
            .IsRequired();

            builder.HasOne(x => x.Puesto)
            .WithMany(x =>x.Incidencias)
            .HasForeignKey(x => x.IdPuesto).IsRequired();

            builder.HasOne(x => x.CategoriaIncidencia)
            .WithMany()
            .HasForeignKey(x => x.IdCategoria)
            .IsRequired();

            builder.HasOne(x => x.Trainer)
            .WithMany(x =>x.Incidencias)
            .HasForeignKey(x => x.IdTrainer).IsRequired();

        }
    }
}