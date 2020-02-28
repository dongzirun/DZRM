using DZRM.Domain.Abstractions;
using DZRM.Domain.OrderAggergate;

namespace DZRM.Domain.Events
{
    public class OrderCreatedDomainEvent : IDomainEvent
    {
        public Order Order { get; private set; }

        public OrderCreatedDomainEvent(Order order)
        {
            this.Order = order;
        }
    }
}