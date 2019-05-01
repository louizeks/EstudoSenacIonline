using IOnlineSenac.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IOnlineSenac.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        Usuario ObterPorId(Guid id);
    }
}
