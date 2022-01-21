using Vidly.DataAcces.Interfaces;
using Vidly.DataAcces.Models;

namespace Vidly.DataAcces.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(VidlyDbContext context) : base(context)
        {
        }
    }
}
