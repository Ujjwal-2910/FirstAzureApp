using Microsoft.EntityFrameworkCore;

namespace FirstAzureHostedWebApp.Models
{
    public class Customer
    {
        public string? CustomerId { get; set; }
        public string? CompanyName { get; set; }
        public string? ContactName { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
    }

    public class CustomersDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public CustomersDbContext(DbContextOptions<CustomersDbContext> options) : base(options)
        {

        }
    }
}
