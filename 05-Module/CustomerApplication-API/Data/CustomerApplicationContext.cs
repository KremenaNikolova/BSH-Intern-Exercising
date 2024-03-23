using System;
using System.Collections.Generic;
using CustomerApplication_API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerApplication_API.Data;

public partial class CustomerApplicationContext : DbContext
{
    public CustomerApplicationContext()
    {
    }

    public CustomerApplicationContext(DbContextOptions<CustomerApplicationContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomersProduct> CustomersProducts { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.Email).HasMaxLength(70);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
        });

        modelBuilder.Entity<CustomersProduct>(entity =>
        {
            entity.HasKey(e => new { e.CustomerId, e.ProductId });

            entity.HasIndex(e => e.ProductId, "IX_CustomersProducts_ProductId");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomersProducts).HasForeignKey(d => d.CustomerId);

            entity.HasOne(d => d.Product).WithMany(p => p.CustomersProducts).HasForeignKey(d => d.ProductId);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasIndex(e => e.CategoryId, "IX_Products_CategoryId");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Category).WithMany(p => p.Products).HasForeignKey(d => d.CategoryId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
