using System;


namespace ServiceDeskBot.Domain.Entidades
{
    public class HistoricoChamado
    {
        public int Id { get; set; }
        public int ChamadoId { get; set; }
        public string CampoAlterado { get; set; }
         public string ValorAnterior { get; set; }
         public string ValorNovo { get; set; }
         public int? AlteradoPorId { get; set; }
        public DateTime DataAlteracao { get; set; }
        
    }
}