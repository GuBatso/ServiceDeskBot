using System.Collections.Generic;

namespace ServiceDeskBot.Domain.Entidades
{
    public class Equipamento
    {
        public int Id { get; set; }
        public int LocalId { get; set; }
        public int? SetorId { get; set; } //um equipamento pode não ter setor
        public required string Fabricante { get; set; }
        public required string Modelo { get; set; }
        public string? Patrimonio { get; set; }
        public bool Critico { get; set; } //se a indisponibilidade do equipamento impacta o negócio

        public Local? Local { get; set; }
        public Setor? Setor { get; set; }

        public ICollection<Chamado> Chamados { get; set; } = new List<Chamado>();
    }
}