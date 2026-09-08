using System;
    

namespace ServiceDeskBot.Domain.Entidades
{
    public class InteracaoChatBot
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public int? ChamadoId { get; set; }
    public required string Estado { get; set; }
    public required string MensagemRecebida { get; set; }
    public string MensagemEnviada { get; set; }
    public DateTime Timestamp { get; set; }
}
}