﻿// <auto-generated />
using System;
using CustomerApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CustomerApplication.Migrations
{
    [DbContext(typeof(CustomerApplicationDbContext))]
    partial class CustomerApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CustomerApplication.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Cloths"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Toys"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Food"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Drinks"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Others"
                        });
                });

            modelBuilder.Entity("CustomerApplication.Data.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CustomerApplication.Data.Models.CustomerProduct", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CustomerId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("CustomersProducts");

                    b.HasData(
                        new
                        {
                            CustomerId = 3,
                            ProductId = 1,
                            Quantity = 2
                        },
                        new
                        {
                            CustomerId = 4,
                            ProductId = 5,
                            Quantity = 1
                        },
                        new
                        {
                            CustomerId = 6,
                            ProductId = 3,
                            Quantity = 11
                        },
                        new
                        {
                            CustomerId = 1,
                            ProductId = 1,
                            Quantity = 1
                        },
                        new
                        {
                            CustomerId = 12,
                            ProductId = 5,
                            Quantity = 3
                        },
                        new
                        {
                            CustomerId = 3,
                            ProductId = 2,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("CustomerApplication.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Name = "Shirt",
                            Price = 5.55m,
                            Quantity = 3
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Name = "Jeans",
                            Price = 15.32m,
                            Quantity = 25
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Name = "Dog-Toy",
                            Price = 3.00m,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Name = "Ball",
                            Price = 1.55m,
                            Quantity = 50
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            Name = "Hamburger",
                            Price = 4.35m,
                            Quantity = 3
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Name = "Chips",
                            Price = 4.25m,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 4,
                            Name = "Coca-Cola",
                            Price = 2.60m,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 4,
                            Name = "Tea",
                            Price = 2.60m,
                            Quantity = 3
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 4,
                            Name = "Soda",
                            Price = 2.60m,
                            Quantity = 12
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 5,
                            Name = "Random-thing",
                            Price = 123.33m,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 5,
                            Name = "Random-thing 2",
                            Price = 123.33m,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("CustomerApplication.Data.Models.CustomerProduct", b =>
                {
                    b.HasOne("CustomerApplication.Data.Models.Customer", "Customer")
                        .WithMany("CustomerProducts")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CustomerApplication.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("CustomerApplication.Data.Models.Product", b =>
                {
                    b.HasOne("CustomerApplication.Data.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CustomerApplication.Data.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("CustomerApplication.Data.Models.Customer", b =>
                {
                    b.Navigation("CustomerProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
