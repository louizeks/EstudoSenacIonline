using IOnlineSenac.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IOnlineSenac.Service.Interfaces
{
    public interface IAcessoService
    {
        bool ValidarAcesso(Guid idUsuario, Guid IdEvento);
    }
}
