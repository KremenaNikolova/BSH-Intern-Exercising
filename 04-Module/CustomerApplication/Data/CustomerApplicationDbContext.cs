namespace CustomerApplication.Data
{
    using CustomerApplication.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class CustomerApplicationDbContext : DbContext
    {
        public CustomerApplicationDbContext(DbContextOptions<CustomerApplicationDbContext> options) : base(options)
        {}

        public DbSet<Customer> Customers { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
