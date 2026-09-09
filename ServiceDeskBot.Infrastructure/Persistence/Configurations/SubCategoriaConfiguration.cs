using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceDeskBot.Domain.Entidades;

namespace ServiceDeskBot.Infrastructure.Persistence.Configurations
{
public class SubCategoriaConfiguration : IEntityTypeConfiguration<SubCategoria>
{
    public void Configure(EntityTypeBuilder<SubCategoria> builder)
    {
        builder.ToTable("SubCategorias");

        builder.Property(sc => sc.Nome)
            .IsRequired()
            .HasMaxLength(100);
    }
}
}