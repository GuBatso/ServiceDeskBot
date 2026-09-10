using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceDeskBot.Domain.Entidades;

namespace ServiceDeskBot.Infrastructure.Persistence.Configurations
{
    public class TecnicoConfiguration : IEntityTypeConfiguration<Tecnico>
    {
        public void Configure(EntityTypeBuilder<Tecnico> builder)
        {
            builder.ToTable("Tecnicos");

            // Chave primária. 
            //builder.HasKey(t => t.Id); o EF já reconhece Id como PK por convenção

            builder.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(t => t.SenhaHash)
                .IsRequired()
                .HasMaxLength(200);

            builder.HasIndex(t => t.Email)
                .IsUnique(); // Garante que o email seja único
        }
    }
}