using AutoMapper;
using System.Collections.Generic;
using Vidly.DataAcces.Interfaces;
using Vidly.DataAcces.Models;
using Vidly.Services.Interfaces;
using Vidly.Services.Models;

namespace Vidly.Services.AppServices
{
    public class CustomerService : ICustomerService
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(
            IMapper mapper, 
            ICustomerRepository customerRepository)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }

        public List<CustomerDto> GetCustomers()
        {
            var entities = _customerRepository.GetAll();
            var customersDto = _mapper.Map<List<CustomerDto>>(entities);
            return customersDto;
        }

        public CustomerDto GetCustomerById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void AddCustomer(CustomerDto customer)
        {
            var entity = _mapper.Map<Customer>(customer);
            _customerRepository.Add(entity);
        }

        public void DeleteCustomer(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCustomer(CustomerDto customer)
        {
            throw new System.NotImplementedException();
        }
    }
}
