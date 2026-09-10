using System.Collections.Generic;

namespace ServiceDeskBot.Domain.Entidades
{
    public class Categoria
    {
        public int Id { get; set; }
        public required string Nome { get; set; }

        public ICollection<SubCategoria> SubCategorias { get; set; } = new List<SubCategoria>();
        public ICollection<Chamado> Chamados { get; set; } = new List<Chamado>();
    }
}