using System;
using System.Collections.Generic;
using System.Text;

namespace Hris.Common.Repositories.Interface
{
    public interface ITransactionAble
    {
        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
        void DisposeTransaction();
    }
}
