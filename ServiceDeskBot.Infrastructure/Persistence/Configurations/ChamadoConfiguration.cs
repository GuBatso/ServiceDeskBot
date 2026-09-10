using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceDeskBot.Domain.Entidades;

namespace ServiceDeskBot.Infrastructure.Persistence.Configurations
{
    public class ChamadoConfiguration : IEntityTypeConfiguration<Chamado>
    {
        public void Configure(EntityTypeBuilder<Chamado> builder)
    {
        builder.ToTable("Chamados");

        builder.Property(c => c.NumeroChamado)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasIndex(c => c.NumeroChamado)
            .IsUnique(); // Garante que o número do chamado seja único

            builder.Property(c => c.Descricao)
            .IsRequired();

            builder.Property(c => c.Impacto)
            .IsRequired()
            .HasMaxLength(20);

            builder.Property(c => c.Status)
            .HasConversion<string>()
            .IsRequired()
            .HasMaxLength(20);

            builder.Property(c => c.Prioridade)
            .HasConversion<string>()
            .IsRequired()
            .HasMaxLength(20);
    }
    }
}