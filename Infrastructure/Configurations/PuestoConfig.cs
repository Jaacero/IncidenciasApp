
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Configurations
{
    public class PuestoConfig : IEntityTypeConfiguration<Puesto>
    {
        public void Configure(EntityTypeBuilder<Puesto> builder)
        {
            builder.HasOne(x => x.Salon)
                .WithMany(x => x.Puestos)
                .HasForeignKey(x => x.IdSalon)
                .IsRequired();

                builder.Property(x => x.NombrePuesto).HasColumnType("varchar(100)");
        }
    }
}