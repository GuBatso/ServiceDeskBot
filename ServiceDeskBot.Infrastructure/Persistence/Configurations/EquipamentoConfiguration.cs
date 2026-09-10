using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceDeskBot.Domain.Entidades;

namespace ServiceDeskBot.Infrastructure.Persistence.Configurations
{
    public class EquipamentoConfiguration : IEntityTypeConfiguration<Equipamento>
    {
        public void Configure(EntityTypeBuilder<Equipamento> builder)
        {
            builder.ToTable("Equipamentos");

           // builder.HasKey(e => e.Id);

            builder.Property(e => e.Fabricante)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Modelo)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Patrimonio)
                .HasMaxLength(50);

            builder.Property(e => e.Critico)
                .HasDefaultValue(false);
                
        }
    }
}