using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class EmailConfig : IEntityTypeConfiguration<EmailsTrainers>
    {
        public void Configure(EntityTypeBuilder<EmailsTrainers> builder)
        {
            
        builder.HasKey(x => new{ x.IdTipoEmail ,x.IdTrainer});

           builder.HasOne(x => x.TipoEmail)
            .WithMany(x =>x.Emails)
            .HasForeignKey(x => x.IdTipoEmail)
            .IsRequired();

            builder.HasOne(x => x.Trainer)
            .WithMany(x =>x.EmailsTrainer)
            .HasForeignKey(x => x.IdTrainer)
            .IsRequired();

            builder.Property(x => x.Email).HasMaxLength(80)
            .IsRequired();
        }
    }
}