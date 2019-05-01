using System;
using System.Collections.Generic;
using System.Text;

namespace Dto
{
    public class ResponseBase
    {
        public bool Erro { get; }
        public string Mensagem { get; set; }

        public ResponseBase() { }

        public ResponseBase(bool erro, string mensagem)
        {
            this.Erro = erro;
            this.Mensagem = mensagem;
        }
    }
}
