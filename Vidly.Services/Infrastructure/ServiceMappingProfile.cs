using AutoMapper;
using Vidly.DataAcces.Models;
using Vidly.Services.Models;

namespace Vidly.Services.Infrastructure
{
    public class ServiceMappingProfile : Profile
    {
        public ServiceMappingProfile()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
        }
    }
}
