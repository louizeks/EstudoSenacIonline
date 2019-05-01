using System;
using System.ComponentModel.DataAnnotations;

namespace IOnlineSenac.DTO.Acesso
{
    public class ValidaAcessoRequest
    {
        public Guid IdUsuario { get; set; }
   
        public Guid IdEvento { get; set; }
    }
}
