using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceDeskBot.Domain.Entidades;

namespace ServiceDeskBot.Infrastructure.Persistence.Configurations
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            // Nome da tabela no PostgreSQL. Igual ao DbSet<Categoria> Categorias { get; set; } no AppDbContext.
            builder.ToTable("Categorias");

            // Chave primária. 
            //builder.HasKey(c => c.Id); o EF já reconhece Id como PK por convenção

            // Nome é obrigatório e tem no máximo 100 caracteres.
            builder.Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}