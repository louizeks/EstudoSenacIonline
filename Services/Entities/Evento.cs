using System;
using System.Collections.Generic;
using System.Text;

namespace IOnlineSenac.Domain.Entities
{
    public class Evento
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Banner { get; set; }
        public Guid AdminId { get; set; }
        public DateTime DataEvento { get; set; }
        public bool Destaque { get; set; }
        public int TipoEventoId { get; set; }
    }
}
