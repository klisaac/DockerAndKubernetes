using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microservice.Api1.Application.Mapper;
using Microservice.Api1.Application.Handlers;

namespace Microservice.Api1.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ApplicationMapper));
            services.AddMediatR(typeof(CreateEmployeeCommandHandler).GetTypeInfo().Assembly);
            return services;
        }
    }
}
