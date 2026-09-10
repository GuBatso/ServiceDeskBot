using System.Collections.Generic;
namespace ServiceDeskBot.Domain.Entidades
{
    public class Setor
    {
        public int Id { get; set; }
        public int LocalId { get; set; }
        public Local? Local { get; set; }
        public required string Nome { get; set; }

        public ICollection<Equipamento> Equipamentos { get; set; } = new List<Equipamento>();
    }
}