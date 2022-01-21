using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Vidly.WebApi.Infrastructure
{
    public static class Bindings
    {
        public static IServiceCollection BindAutoMapper(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            mappingConfig.AssertConfigurationIsValid();

            services.AddSingleton(mappingConfig.CreateMapper());

            return services;
        }
    }
}
