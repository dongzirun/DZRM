using DZRM.Domain.OrderAggergateBoot;
using DZRM.Infrastucture.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace DZRM.Infrastructure.Repositories
{
    public interface IOrderRepository : IRepository<Order, long>
    {
    }
}
