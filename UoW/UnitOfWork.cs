using System;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using UoW.Interfaces;

namespace UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private IConfiguration _configuration;
        private SqlConnection _conexao;
        private SqlTransaction _transaction;
        private IAcessoRepository _acessoRepository;
        private bool _disposed;

        public UnitOfWork(IConfiguration configuracoes)
        {
            _configuration = configuracoes;
            _conexao = new SqlConnection(_configuration.GetConnectionString("IOnlineDB"));
            _conexao.Open();
            _transaction = _conexao.BeginTransaction();
        }

        public IAcessoRepository AcessoRepository
        {
            get { return _acessoRepository ?? (_acessoRepository = new AcessoRepository(_transaction)); }
        }

        public void Commit()
        {
            try
            {
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction.Dispose();
                _transaction = _conexao.BeginTransaction();
                ResetRepositories();
            }
        }

        private void ResetRepositories()
        {
            _acessoRepository = null;
        }

        public void Dispose()
        {
            dispose(true);
            GC.SuppressFinalize(this);
        }

        private void dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_transaction != null)
                    {
                        _transaction.Dispose();
                        _transaction = null;
                    }
                    if (_conexao != null)
                    {
                        _conexao.Dispose();
                        _conexao = null;
                    }
                }
                _disposed = true;
            }
        }

        ~UnitOfWork()
        {
            dispose(false);
        }
    }
}