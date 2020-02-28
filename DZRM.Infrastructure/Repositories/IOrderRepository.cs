using DZRM.Domain.OrderAggergate;
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
