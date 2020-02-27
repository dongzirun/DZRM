using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DZRM.Infrastucture.Core
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> SaveChangeAsync(CancellationToken cancellationToken = default);
        Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default);
    }
}
