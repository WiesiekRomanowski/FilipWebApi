using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Vidly.DataAcces.Interfaces;
using Vidly.DataAcces.Repositories;

namespace Vidly.DataAcces.Infrastructure
{
    public static class Bindings
    {
        public static IServiceCollection AddDalBindings(this IServiceCollection services)
        {
            services.AddDbContext<VidlyDbContext>(options =>
                options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=FilipVidly; Integrated Security=SSPI;"));

            services.AddTransient<ICustomerRepository, CustomerRepository>();
            return services;
        }
    }
}
