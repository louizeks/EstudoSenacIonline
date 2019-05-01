using Dapper;
using IOnlineSenac.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data;

namespace IOnlineSenac.Data.Repository.Dapper
{
    public class AcessoRepository : RepositoryBase, IAcessoRepository
    {
        public AcessoRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }

        public bool ValidarAcesso(Guid idUsuario, Guid idEvento)
        {

            var sql = "SELECT Count(Id) FROM Acesso Where UsuarioId = @idUsuario and EventoId = @idEvento and DataHoraAcesso is null";

            var podeAcessar = _connection.ExecuteScalar<bool>(sql
               , new
               {
                   idUsuario,
                   idEvento
               }, transaction: _transaction);

   
           return podeAcessar;
        }
    }
}
