using DotNetCore.CAP;
using DZRM.Domain.OrderAggergate;
using DZRM.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DZRM.API.Applications.Commands
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, long>
    {
        IOrderRepository _orderRepository;
        ICapPublisher _capPublisher;
        public CreateOrderCommandHandler(IOrderRepository orderRepository, ICapPublisher capPublisher)
        {
            _orderRepository = orderRepository;
            _capPublisher = capPublisher;
        }
        public async Task<long> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var addr = new Address("华强北", "深圳市", "500008");
            var order = new Order("10001", "董子润", 5, addr);

            _orderRepository.Add(order);
            await _orderRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
            return order.Id;
        }
    }
}
