using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceDeskBot.Domain.Enums;

namespace ServiceDeskBot.Domain.Entidades
{
    public class Chamado
    {
        public int Id { get; set; }
        public required string NumeroChamado { get; set; }
        
        public int UsuarioId { get; set; }
        public int LocalId { get; set; }
        public int CategoriaId { get; set; }
        public int? SubCategoriaId { get; set; }
        public int? EquipamentoId { get; set; }
        public int? TecnicoId { get; set; }
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
    }
}