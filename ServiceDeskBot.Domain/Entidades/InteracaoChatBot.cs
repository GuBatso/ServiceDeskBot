using System;
    

namespace ServiceDeskBot.Domain.Entidades
{
    public class InteracaoChatbot
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public int? ChamadoId { get; set; }
    public string Estado { get; set; }
    public string MensagemRecebida { get; set; }
    public string MensagemEnviada { get; set; }
    public DateTime Timestamp { get; set; }
}
}