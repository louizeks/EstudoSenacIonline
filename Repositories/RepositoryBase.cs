using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IOnlineSenac.Data.Repository
{
    public class RepositoryBase
    {
        protected IDbTransaction _transaction { get; private set; }
        protected IDbConnection _connection { get { return _transaction.Connection; } }

        public RepositoryBase(IDbTransaction transaction)
        {
            _transaction = transaction;
        }
    }
}
