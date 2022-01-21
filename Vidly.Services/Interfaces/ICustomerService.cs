using System.Collections.Generic;
using Vidly.Services.Models;

namespace Vidly.Services.Interfaces
{
    public interface ICustomerService
    {
        List<CustomerDto> GetCustomers();
        CustomerDto GetCustomerById(int id);
        void AddCustomer(CustomerDto customer);
        void DeleteCustomer(int id);
        void UpdateCustomer(CustomerDto customer);
    }
}
