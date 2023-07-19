using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class SalonConfig : IEntityTypeConfiguration<Salon>
    {
        public void Configure(EntityTypeBuilder<Salon> builder)
        {
                builder.HasOne(x => x.Area)
                .WithMany(x => x.Salones)
                .HasForeignKey(x => x.IdArea)
                .IsRequired();

                builder.Property(x => x.NombreSalon).HasColumnType("varchar(100)")
                .IsRequired();
        }
    }
}