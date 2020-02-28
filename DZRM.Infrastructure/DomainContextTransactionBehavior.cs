using DotNetCore.CAP;
using DZRM.Infrastucture.Core.Behaviors;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace DZRM.Infrastructure
{
    public class DomainContextTransactionBehavior<TRequest, TResponse> :
         TransactionBehaviors<DomainContext, TRequest, TResponse>
    {
        public DomainContextTransactionBehavior(DomainContext dbcontext, ICapPublisher capBus, ILogger<DomainContextTransactionBehavior<TRequest, TResponse>> logger) : base(dbcontext, capBus, logger)
        {

        }
    }
}
