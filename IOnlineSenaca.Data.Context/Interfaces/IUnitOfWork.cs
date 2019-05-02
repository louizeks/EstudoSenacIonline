
using IOnlineSenac.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace IOnlineSenac.Data.Context.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAcessoRepository AcessoRepository { get; }
        IUsuarioRepository UsuarioRepository { get; }
        IEventoRepository EventoRepository { get;  }
        void Commit();
    }
}
