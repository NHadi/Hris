using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Hris.Common.Repositories.Interface
{
    public interface IDbContextFactory
    {
        IDbConnection GetDbConnection(string connectionString);
        string GetConnectionString(string connectionDb);
    }
}
