using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DZRM.Infrastucture.Core
{
    public class EFContext : DbContext, IUnitOfWork
    {
        public EFContext(DbContextOptions options) : base(options)
        {

        }

        public Task<int> SaveChangeAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            var result = await base.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
