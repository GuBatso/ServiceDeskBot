namespace ServiceDeskBot.Domain.Entidades
{
    public class Tecnico
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Email { get; set; }
        public required string SenhaHash { get; set; }
        public bool Ativo { get; set; }
    }
}