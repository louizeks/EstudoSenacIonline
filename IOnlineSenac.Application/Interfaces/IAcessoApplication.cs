using IOnlineSenac.DTO.Acesso;
using System;
using System.Collections.Generic;
using System.Text;

namespace IOnlineSenac.Application.Interfaces
{
    public interface IAcessoApplication
    {
        ValidaAcessoResponse ValidarAcesso(ValidaAcessoRequest request);
    }
}
