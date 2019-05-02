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
    public class EventoRepository : RepositoryBase, IEventoRepository
    {
        public EventoRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public List<Evento> ObterEventos()
        {
            var sql = "Select * from Evento";

            return _connection.Query<Evento>(sql, _transaction).ToList();

        }
    }
}
