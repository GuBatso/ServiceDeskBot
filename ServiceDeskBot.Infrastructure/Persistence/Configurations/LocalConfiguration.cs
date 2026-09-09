using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceDeskBot.Domain.Entidades;

namespace ServiceDeskBot.Infrastructure.Persistence.Configurations
{
    // Configuração de mapeamento da entidade Local para o banco.
    public class LocalConfiguration : IEntityTypeConfiguration<Local>
    {
        public void Configure(EntityTypeBuilder<Local> builder)
        {
            // Nome da tabela no PostgreSQL. Igual ao DbSet<Local> Locais { get; set; } no AppDbContext.
            builder.ToTable("Locais");

            // Chave primária. 
            //builder.HasKey(l => l.Id); o EF já reconhece Id como PK por convenção

            // Nome é obrigatório e tem no máximo 100 caracteres.
            builder.Property(l => l.Nome)
                .IsRequired()
                .HasMaxLength(100);

            // Ativo é obrigatório e começa como true por padrão.
            builder.Property(l => l.Ativo)
                .IsRequired()
                .HasDefaultValue(true);
        }
    }
}