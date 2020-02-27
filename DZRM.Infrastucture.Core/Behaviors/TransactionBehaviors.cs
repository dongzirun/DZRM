using DotNetCore.CAP;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DZRM.Infrastucture.Core.Behaviors
{
    public class TransactionBehaviors<TDbContext, TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TDbContext : EFContext
    {
        ILogger _logger;
        TDbContext _dbContext;
        ICapPublisher _capBus;
        public TransactionBehaviors(TDbContext dbContext, ICapPublisher capBus, ILogger logger)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _capBus = capBus ?? throw new ArgumentNullException(nameof(capBus));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            throw new NotImplementedException();
        }
    }
}
