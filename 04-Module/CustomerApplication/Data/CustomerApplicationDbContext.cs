namespace CustomerApplication.Data
{
    using CustomerApplication.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class CustomerApplicationDbContext : DbContext
    {
        public CustomerApplicationDbContext(DbContextOptions<CustomerApplicationDbContext> options) : base(options)
        { }

        public DbSet<Customer> Customers { get; set; } = null!;

        public DbSet<Product> Products { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<CustomerProduct> CustomersProducts { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);

            builder
                .Entity<Category>()
                .HasMany(c=>c.Products)
                .WithOne(p=>p.Category)
                .HasForeignKey(p=>p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .Entity<Customer>()
                .HasMany(c=>c.CustomerProducts)
                .WithOne(cp=>cp.Customer)
                .HasForeignKey(ci=>ci.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);
            
            builder
                .Entity<CustomerProduct>()
                .HasKey(cp => new { cp.CustomerId, cp.ProductId });


            base.OnModelCreating(builder);
        }
    }
}
