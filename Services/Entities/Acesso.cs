using System;

namespace IOnlineSenac.Domain.Entities
{
    public class Acesso
    {
        public Guid Id { get; set; }
        public Guid EventoId { get; set; }
        public Guid UsuarioId { get; set; }
        public DateTime DataAcesso { get; set; }
    }
}
