using DZRM.Domain.OrderAggergate;
using DZRM.Infrastucture.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace DZRM.Infrastructure.Repositories
{
    public class OrderRepository : Repository<Order, long, DomainContext>, IOrderRepository
    {
        public OrderRepository(DomainContext context) : base(context)
        {

        }
    }
}
