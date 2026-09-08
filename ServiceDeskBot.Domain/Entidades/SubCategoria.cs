

namespace ServiceDeskBot.Domain.Entidades
{
    public class SubCategoria
    {
        public int Id { get; set; }
        public int CategoriaId { get; set; }
        public required string Nome { get; set; }
    }
}