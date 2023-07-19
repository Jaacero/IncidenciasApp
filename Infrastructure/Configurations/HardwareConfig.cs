using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class HardwareConfig : IEntityTypeConfiguration<Hardware>
    {
        public void Configure(EntityTypeBuilder<Hardware> builder)
        {
            builder.HasOne(x => x.TipoHardware)
            .WithMany(x =>x.Hardwares)
            .HasForeignKey(x => x.TipoHardwareId)
            .IsRequired();

            builder.HasOne(x => x.Puesto)
            .WithMany(x =>x.Hardwars)
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