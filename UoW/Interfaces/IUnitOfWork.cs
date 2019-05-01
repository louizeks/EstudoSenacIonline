using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace UoW.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAcessoRepository AcessoRepository { get; }
        void Commit();
    }
}
