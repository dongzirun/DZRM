using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DZRM.API.Applications.IntegrationEvents
{
    public interface ISubscriberServices
    {
        void OrderPaymentSucceeded(OrderPaymentSucceededIntegrationEvent @event);
    }
}
