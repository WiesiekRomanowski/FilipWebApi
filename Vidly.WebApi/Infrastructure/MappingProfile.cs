using Vidly.Services.Infrastructure;
using Vidly.Services.Models;
using Vidly.WebApi.Models;

namespace Vidly.WebApi.Infrastructure
{
    public class MappingProfile : ServiceMappingProfile
    {
        public MappingProfile()
        {
            CreateMap<CustomerDto, CustomerViewModel>()
                .ForMember(dest => dest.FullName, opts => opts.MapFrom(src => GetFullName(src.FirstName, src.LastName)));
        }

        private string GetFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
    }
}
