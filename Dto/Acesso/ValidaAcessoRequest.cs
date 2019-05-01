using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dto.Acesso
{
    public class ValidaAcessoRequest
    {
        [Required]
        public Guid IdUsuario { get; set; }
        [Required]
        public Guid IdEvento { get; set; }
    }
}
