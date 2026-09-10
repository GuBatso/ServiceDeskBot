using System;
using ServiceDeskBot.Domain.Enums;
using System.Collections.Generic;

namespace ServiceDeskBot.Domain.Entidades
{
    public class Chamado
    {
        public int Id { get; set; }
        public required string NumeroChamado { get; set; }

        // FK obrigatória + navegação
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        // Bug corrigido: era "public Local LocalId" (tipo errado).
        // Agora LocalId é o int (FK) e Local é a navegação, separados.
        public int LocalId { get; set; }
        public Local? Local { get; set; }

        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }

        // FKs opcionais + navegação também opcional
        public int? SubCategoriaId { get; set; }
        public SubCategoria? SubCategoria { get; set; }

        public int? EquipamentoId { get; set; }
        public Equipamento? Equipamento { get; set; }

        public int? TecnicoId { get; set; }
        public Tecnico? Tecnico { get; set; }

        public required string Descricao { get; set; }
        public required string Impacto { get; set; }

        public DateTime DataAbertura { get; set; }
        public DateTime? DataInicioAtendimento { get; set; }
        public DateTime? DataConclusao { get; set; }

        public string? Diagnostico { get; set; }
        public string? Solucao { get; set; }
        public string? Observacao { get; set; }

        public StatusChamado Status { get; set; }
        public PrioridadeChamado Prioridade { get; set; }

        public ICollection<HistoricoChamado> HistoricoChamados { get; set; } = new List<HistoricoChamado>();
        public ICollection<InteracaoChatBot> InteracoesChatBot { get; set; } = new List<InteracaoChatBot>();
    }
}