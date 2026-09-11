using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceDeskBot.Domain.Entidades;

namespace ServiceDeskBot.Infrastructure.Persistence.Configurations
{
    public class InteracaoChatBotConfiguration : IEntityTypeConfiguration<InteracaoChatBot>
    {
        public void Configure(EntityTypeBuilder<InteracaoChatBot> builder)
        {
            builder.ToTable("InteracoesChatBot");

            builder.Property(i => i.Estado)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(i => i.MensagemRecebida)
                .IsRequired();
            
            builder.Property(i => i.MensagemEnviada)
                .IsRequired(false);

            builder.Property(i => i.Timestamp)
                .IsRequired();  

            
        }
    }
}