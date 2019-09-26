using System;
using System.Collections.Generic;
using System.Text;

namespace Hris.Common.Repositories.Interface
{
    public interface IDapperRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> FromSql(string query = null, object param = null);
        void FromSqlWithoutReturn(string query = null, object param = null);
    }
}
