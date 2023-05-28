using System.Reflection;
using Application.Pipeline;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    // Register all dependencies here to make it flow to other layers
    public static class ServiceCollectionExtensions
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services
                // Auto Mapper
                .AddAutoMapper(Assembly.GetExecutingAssembly())
                // MediatR
                .AddMediatR(Assembly.GetExecutingAssembly())
                // Fluent Validation
                .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly())
                // Custom Exception MediatR
                .AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationPipelineBehavior<,>));


        }
    }
}
