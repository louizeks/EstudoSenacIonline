using Dapper;
using IOnlineSenac.Domain.Entities;
using IOnlineSenac.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace IOnlineSenac.Data.Repository.Dapper
{
    public class UsuarioRepository : RepositoryBase, IUsuarioRepository
    {
        public UsuarioRepository(IDbTransaction transaction)
            : base(transaction)
        {}

        public Usuario ObterPorId(Guid id)
        {
            var sql = "Select * From Usuario Where Id = @Id";

           return _connection.Query<Usuario>(sql, new { Id = id }, transaction: _transaction).FirstOrDefault();
        }
    }
}
