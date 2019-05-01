using System;

namespace Entities
{
    public class Acesso
    {
        public Guid Id { get; set; }
        public Guid EventoId { get; set; }
        public Guid UsuarioId { get; set; }
        public DateTime DataAcesso { get; set; }
    }
}
