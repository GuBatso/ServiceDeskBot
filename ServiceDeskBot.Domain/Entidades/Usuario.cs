namespace ServiceDeskBot.Domain.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Telefone { get; set; }
    }
}