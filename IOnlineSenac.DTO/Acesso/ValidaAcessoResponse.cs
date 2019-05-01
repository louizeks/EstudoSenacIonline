using System;


namespace IOnlineSenac.DTO.Acesso
{
    public class ValidaAcessoResponse : ResponseBase
    {
        public Guid UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool PodeAcessar { get; set; }
    }
}
