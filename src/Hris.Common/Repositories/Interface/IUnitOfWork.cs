using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hris.Common.Repositories.Interface
{
    public interface IUnitOfWork<TContext> : ITransactionAble, IDisposable 
        where TContext : DbContext
    {
        TContext Context { get; }
        void Commit();
        Task CommitAsync();
    }
}
