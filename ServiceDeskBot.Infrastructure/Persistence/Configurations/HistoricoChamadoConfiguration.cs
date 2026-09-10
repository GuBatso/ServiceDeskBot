using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceDeskBot.Domain.Entidades;

namespace ServiceDeskBot.Infrastructure.Persistence.Configurations
{
    public class HistoricoChamadoConfiguration : IEntityTypeConfiguration<HistoricoChamado>
    {
        public void Configure(EntityTypeBuilder<HistoricoChamado> builder)
        {
            builder.ToTable("HistoricosChamados");

            builder.HasKey(h => h.Id);

            builder.Property(h => h.DataAlteracao)
                .IsRequired();

            builder.Property(h => h.CampoAlterado)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(h => h.ValorNovo)
                .IsRequired();
            
            builder.Property(h => h.ValorAnterior)
                .IsRequired(false);

            builder.Property(h => h.AlteradoPorId)
                .IsRequired();
        }
    }
}