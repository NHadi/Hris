using Dapper;
using Hris.Common.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Hris.Common.Repositories
{
    public class DapperRepository<TEntity> : IDapperRepository<TEntity> where TEntity : class

    {
        private readonly IDbConnection _sqlConnection;
        public DapperRepository(IDbConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }


        public IEnumerable<TEntity> FromSql(string query = null, object param = null)
        {

            using (_sqlConnection)
            {
                _sqlConnection.Open();
                return _sqlConnection.Query<TEntity>(query, param);
            }
        }

        public void FromSqlWithoutReturn(string query = null, object param = null)
        {

            using (_sqlConnection)
            {
                _sqlConnection.Open();
                _sqlConnection.Execute(query, param);
            }
        }
    }
}
