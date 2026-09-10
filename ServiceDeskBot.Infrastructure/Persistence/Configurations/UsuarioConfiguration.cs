using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceDeskBot.Domain.Entidades;

namespace ServiceDeskBot.Infrastructure.Persistence.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("Usuarios");

        //basicamente aqui não cria indice para melhorar a performance da busca
        //se fosse index  toda vez que fosse inserido um novo registro, o banco teria que atualizar o indice, o que poderia impactar a performance de inserção
        builder.Property(u => u.Nome)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasIndex(u => u.Telefone)
        .IsUnique(); // Garante que o telefone seja único

            builder.Property(u => u.Telefone)
                .HasMaxLength(13)
                .IsRequired(); // Garante que o telefone seja obrigatório
                
        }
    }
}