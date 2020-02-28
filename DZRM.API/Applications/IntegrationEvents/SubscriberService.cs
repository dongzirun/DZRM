using DotNetCore.CAP;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DZRM.API.Applications.IntegrationEvents
{
    public class SubscriberService : ISubscriberServices, ICapSubscribe
    {
        IMediator _mediator;
        public SubscriberService(IMediator mediator)
        {
            _mediator = mediator;
        }

        [CapSubscribe(nameof(OrderPaymentSucceeded))]
        public void OrderPaymentSucceeded(OrderPaymentSucceededIntegrationEvent @event)
        {
            Console.WriteLine("OrderPaymentSucceeded");
        }

        [CapSubscribe(nameof(OrderCreated))]
        public void OrderCreated(OrderCreatedIntegrationEvent @event)
        {
            Console.WriteLine("OrderCreated");
        }
    }
}
