using System;
using System.Collections.Generic;
using System.Text;

namespace IOnlineSenac.DTO.Usuario
{
    public class UsuarioResponse
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Senha { get; set; }
        public bool Admin { get; set; }
    }
}
