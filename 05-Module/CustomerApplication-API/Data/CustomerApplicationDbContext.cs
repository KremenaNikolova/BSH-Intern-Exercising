namespace CustomerApplication_API.Data
{
    using CustomerApplication_API.Data.Entities;
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
                .Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .Entity<Customer>()
                .HasMany(c => c.CustomerProducts)
                .WithOne(cp => cp.Customer)
                .HasForeignKey(ci => ci.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .Entity<CustomerProduct>()
                .HasKey(cp => new { cp.CustomerId, cp.ProductId });


            builder
                .Entity<Category>()
                .HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Cloths"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Toys"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Food"
                },
                new Category()
                {
                    Id = 4,
                    Name = "Drinks"
                },
                new Category()
                {
                    Id = 5,
                    Name = "Others"
                });

            builder
                .Entity<Product>()
                .HasData(
                new Product()
                {
                    Id = 1,
                    Name = "Shirt",
                    CategoryId = 1,
                    Price = 5.55M,
                    Quantity = 3
                },
                new Product()
                {
                    Id = 2,
                    Name = "Jeans",
                    CategoryId = 1,
                    Price = 15.32M,
                    Quantity = 25
                },
                new Product()
                {
                    Id = 3,
                    Name = "Dog-Toy",
                    CategoryId = 2,
                    Price = 3.00M,
                    Quantity = 2
                },
                new Product()
                {
                    Id = 4,
                    Name = "Ball",
                    CategoryId = 2,
                    Price = 1.55M,
                    Quantity = 50
                },
                new Product()
                {
                    Id = 5,
                    Name = "Hamburger",
                    CategoryId = 3,
                    Price = 4.35M,
                    Quantity = 3
                },
                new Product()
                {
                    Id = 6,
                    Name = "Chips",
                    CategoryId = 3,
                    Price = 4.25M,
                    Quantity = 1
                },
                new Product()
                {
                    Id = 7,
                    Name = "Coca-Cola",
                    CategoryId = 4,
                    Price = 2.60M,
                    Quantity = 2
                },
                new Product()
                {
                    Id = 8,
                    Name = "Tea",
                    CategoryId = 4,
                    Price = 2.60M,
                    Quantity = 3
                },
                new Product()
                {
                    Id = 9,
                    Name = "Soda",
                    CategoryId = 4,
                    Price = 2.60M,
                    Quantity = 12
                },
                new Product()
                {
                    Id = 10,
                    Name = "Random-thing",
                    CategoryId = 5,
                    Price = 123.33M,
                    Quantity = 1
                },
                new Product()
                {
                    Id = 11,
                    Name = "Random-thing 2",
                    CategoryId = 5,
                    Price = 123.33M,
                    Quantity = 1
                });

            builder.Entity<CustomerProduct>()
                .HasData(
                new CustomerProduct()
                {
                    CustomerId = 5,
                    ProductId = 1,
                    Quantity = 2
                },
                new CustomerProduct()
                {
                    CustomerId = 4,
                    ProductId = 5,
                    Quantity = 1
                },
                new CustomerProduct()
                {
                    CustomerId = 6,
                    ProductId = 3,
                    Quantity = 11
                },
                new CustomerProduct()
                {
                    CustomerId = 1,
                    ProductId = 1,
                    Quantity = 1
                },
                new CustomerProduct()
                {
                    CustomerId = 12,
                    ProductId = 5,
                    Quantity = 3
                },
                new CustomerProduct()
                {
                    CustomerId = 3,
                    ProductId = 2,
                    Quantity = 1
                });

            base.OnModelCreating(builder);
        }
    }
}
