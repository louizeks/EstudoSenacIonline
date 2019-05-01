using System;
using System.Data.SqlClient;
using IOnlineSenac.Data.Context.Interfaces;
using IOnlineSenac.Data.Repository.Dapper;
using IOnlineSenac.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;

namespace IOnlineSenac.Data.Context
{
    public class UnitOfWork : IUnitOfWork
    {
        private IConfiguration _configuration;
        private SqlConnection _connection;
        private SqlTransaction _transaction;
        private IAcessoRepository _acessoRepository;
        private IUsuarioRepository _usuarioRepository;
        private bool _disposed;

        public UnitOfWork(IConfiguration configuracoes)
        {
            _configuration = configuracoes;
            _connection = new SqlConnection(_configuration.GetConnectionString("IOnlineDB"));
            _connection.Open();
            _transaction = _connection.BeginTransaction();
        }

        public IAcessoRepository AcessoRepository
        {
            get { return _acessoRepository ?? (_acessoRepository = new AcessoRepository(_transaction)); }
        }
        public IUsuarioRepository UsuarioRepository
        {
            get { return _usuarioRepository ?? (_usuarioRepository = new UsuarioRepository(_transaction)); }
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
                _transaction = _connection.BeginTransaction();
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
                    if (_connection != null)
                    {
                        _connection.Dispose();
                        _connection = null;
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