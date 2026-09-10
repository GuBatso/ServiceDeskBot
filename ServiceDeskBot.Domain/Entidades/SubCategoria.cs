using System.Collections.Generic;
namespace ServiceDeskBot.Domain.Entidades
{
    public class SubCategoria
    {
        public int Id { get; set; }
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
        public required string Nome { get; set; }
        public ICollection<Chamado> Chamados { get; set; } = new List<Chamado>();
    }
}