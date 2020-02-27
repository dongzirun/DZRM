using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace DZRM.Domain.Abstractions
{
    public interface IDomainEventHandler<TDomainEvent> : INotificationHandler<TDomainEvent>
        where TDomainEvent : IDomainEvent
    {
    }
}
