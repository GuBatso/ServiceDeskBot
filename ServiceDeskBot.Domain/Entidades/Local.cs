

namespace ServiceDeskBot.Domain.Entidades
{
    public class Local
    {
         public int Id { get; set; }
        public required string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}