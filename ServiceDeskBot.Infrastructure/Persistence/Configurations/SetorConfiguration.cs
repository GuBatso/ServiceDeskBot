using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceDeskBot.Domain.Entidades;

namespace ServiceDeskBot.Infrastructure.Persistence.Configurations
{
    public class SetorConfiguration : IEntityTypeConfiguration<Setor>
    {
        public void Configure(EntityTypeBuilder<Setor> builder)
        {
            // Nome da tabela no PostgreSQL. Igual ao DbSet<Setor> Setores { get; set; } no AppDbContext.
            builder.ToTable("Setores");

            // Chave primária. 
            //builder.HasKey(s => s.Id); o EF já reconhece Id como PK por convenção

            // Nome é obrigatório e tem no máximo 100 caracteres.
            builder.Property(s => s.Nome)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}