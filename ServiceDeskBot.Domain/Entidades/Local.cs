using System.Collections.Generic;

namespace ServiceDeskBot.Domain.Entidades
{
    public class Local
    {
         public int Id { get; set; }
        public required string Nome { get; set; }
        public bool Ativo { get; set; }

        public ICollection<Setor> Setores { get; set; } = new List<Setor>();
        public ICollection<Equipamento> Equipamentos { get; set; } = new List<Equipamento>();
        public ICollection<Chamado> Chamados { get; set; } = new List<Chamado>();
    }
}