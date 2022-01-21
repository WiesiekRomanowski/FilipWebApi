using Microsoft.EntityFrameworkCore;
using Vidly.DataAcces.Models;

namespace Vidly.DataAcces
{
    public class VidlyDbContext : DbContext
    {
        public VidlyDbContext(DbContextOptions<VidlyDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
