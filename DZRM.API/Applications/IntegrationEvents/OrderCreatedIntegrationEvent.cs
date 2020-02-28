using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DZRM.API.Applications.IntegrationEvents
{
    public class OrderCreatedIntegrationEvent
    {
        public OrderCreatedIntegrationEvent(long orderId) => OrderId = orderId;
        public long OrderId { get; }
    }
}
