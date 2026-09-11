using System.Collections.Generic;

namespace ServiceDeskBot.Domain.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Telefone { get; set; }
        public bool Ativo { get; set; }

        public ICollection<Chamado> Chamados { get; set; } = new List<Chamado>();
        public ICollection<InteracaoChatBot> InteracoesChatBot { get; set; } = new List<InteracaoChatBot>();
    }
}