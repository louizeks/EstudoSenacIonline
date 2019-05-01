using System;
using System.Collections.Generic;
using System.Text;

namespace IOnlineSenac.Domain.Interfaces.Repositories
{
    public interface IAcessoRepository 
    {
        bool ValidarAcesso(Guid idUsuario, Guid idEvento);
    }
}
