using Microsoft.EntityFrameworkCore;
using CustomerListingAPI.Models;

namespace CustomerListingAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Customer> Customer { get; set; }
    }
}
