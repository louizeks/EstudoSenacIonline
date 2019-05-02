using System;
using System.Collections.Generic;
using System.Text;

namespace IOnlineSenac.DTO.Evento
{
    public class ObterEventosResponse
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Banner { get; set; }
        public DateTime DataEvento { get; set; }
        public bool Destaque { get; set; }
    }
}
