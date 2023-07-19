using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Configurations
{
    public class SofwareConfig : IEntityTypeConfiguration<Software>
    {
        public void Configure(EntityTypeBuilder<Software> builder)
        {
           builder.HasOne(x => x.TipoSoftware)
            .WithMany(x =>x.Softwares)
            .HasForeignKey(x => x.TipoSofwareId)
            .IsRequired();

            builder.HasOne(x => x.Puesto)
            .WithMany(x =>x.Softwars)
            .HasForeignKey(x => x.IdPuesto).IsRequired();

            builder.HasOne(x => x.Categoria)
            .WithMany()
            .HasForeignKey(x => x.IdCategoria)
            .IsRequired();

            builder.Property(x => x.Descripcion).HasMaxLength(200)
            .IsRequired();
        }
    }
}