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

            // Relacionamento com Usuario: impede excluir um Usuario
            // enquanto ele tiver Chamados vinculados.
            //Propriedade de navegação para o relacionamento com Usuario
            builder.HasOne(c => c.Usuario)          // "Chamado tem UM Usuario" (a navegação)
                .WithMany(u => u.Chamados)          // "e Usuario tem VÁRIOS Chamados" (a coleção do outro lado)
                .HasForeignKey(c => c.UsuarioId)    // "a FK que liga é UsuarioId"
                .OnDelete(DeleteBehavior.Restrict); // "impede excluir o Usuario se houver Chamado vinculado"

            builder.HasOne(c => c.Local)          // "Chamado tem UM Local" (a navegação)
                .WithMany(l => l.Chamados)          // "e Local tem VÁRIOS Chamados" (a coleção do outro lado)
                .HasForeignKey(c => c.LocalId)    // "a FK que liga é LocalId"
                .OnDelete(DeleteBehavior.Restrict); // "impede excluir o Local se houver Chamado vinculado"

            builder.HasOne(c => c.Categoria)          // "Chamado tem UMA Categoria" (a navegação)
                .WithMany(cat => cat.Chamados)          // "e Categoria tem VÁRIOS Chamados" (a coleção do outro lado)
                .HasForeignKey(c => c.CategoriaId)    // "a FK que liga é CategoriaId"
                .OnDelete(DeleteBehavior.Restrict); // "impede excluir a Categoria se houver Chamado vinculado"
    }
    }
}