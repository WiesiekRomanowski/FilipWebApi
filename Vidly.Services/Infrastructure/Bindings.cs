using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Vidly.Services.AppServices;
using Vidly.Services.Interfaces;

namespace Vidly.Services.Infrastructure
{
    public static class Bindings
    {
        public static IServiceCollection AddSlBindings(this IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();
            return services;
        }
    }
}
