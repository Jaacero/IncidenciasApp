using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class TelefonosConfig : IEntityTypeConfiguration<TelefonosTrainers>
    {
        public void Configure(EntityTypeBuilder<TelefonosTrainers> builder)
        {
            builder.HasKey(x => new{ x.IdTipoTelefono ,x.IdTrainer});

            builder.HasOne(x => x.TipoTelefono)
            .WithMany(x =>x.Telefonos)
            .HasForeignKey(x => x.IdTipoTelefono)
            .IsRequired();

            builder.HasOne(x => x.Trainer)
            .WithMany(x =>x.TelefonosTrainer)
            .HasForeignKey(x => x.IdTrainer)
            .IsRequired();

            builder.Property(x =>x.NumeroTelefono).HasMaxLength(20)
            .IsRequired();

        }
    }
}