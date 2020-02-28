using DZRM.API.Applications.IntegrationEvents;
using DZRM.Domain.OrderAggergate;
using DZRM.Infrastructure;
using DZRM.Infrastructure.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DZRM.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMediatRServices(this IServiceCollection services)
        {
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(DomainContextTransactionBehavior<,>));
            return services.AddMediatR(typeof(Order).Assembly, typeof(Program).Assembly);
        }

        public static IServiceCollection AddDomainContext(this IServiceCollection services, Action<DbContextOptionsBuilder> action)
        {
            return services.AddDbContext<DomainContext>(action);
        }

        public static IServiceCollection AddInMemoryDomainContext(this IServiceCollection services)
        {
            return services.AddDomainContext(builder => builder.UseInMemoryDatabase("domanContextDatabase"));
        }

        public static IServiceCollection AddMySqlDomainContext(this IServiceCollection services, string constr)
        {
            return services.AddDomainContext(builder =>
            {
                builder.UseMySql(constr);
            });
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IOrderRepository, OrderRepository>();
            return services;
        }

        public static IServiceCollection AddEventBus(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<ISubscriberServices, SubscriberService>();
            services.AddCap(options =>
            {
                options.UseEntityFramework<DomainContext>();
                options.UseRabbitMQ(options =>
                {
                    configuration.GetSection("RabbitMQ").Bind(options);
                });
                //options.UseDashboard();
            });
            return services;
        }
    }
}
