using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;

namespace DZRM.Infrastucture.Core
{
    public interface ITransaction
    {
        IDbContextTransaction GetCurrentTransaction();
        bool HasActiveTransaction { get; }
        Task<IDbContextTransaction> BeginTransactionAsync();
        Task CommitTransactionAsync(IDbContextTransaction dbContextTransaction);
        void RollbackTransaction();
    }
}
