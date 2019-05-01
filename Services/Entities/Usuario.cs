using System;
using System.Collections.Generic;
using System.Text;

namespace IOnlineSenac.Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Admin { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
