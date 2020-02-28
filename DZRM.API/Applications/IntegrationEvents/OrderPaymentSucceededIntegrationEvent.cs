using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DZRM.API.Applications.IntegrationEvents
{
    public class OrderPaymentSucceededIntegrationEvent
    {
        public long OrderId { get; }
        public OrderPaymentSucceededIntegrationEvent(long orderId)
        {
            OrderId = orderId;
        }

    }
}
