using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DZRM.Domain
{
    public interface IDomainEvent : INotification
    {
    }
}
