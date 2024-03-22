using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CustomerApplication.Migrations
{
    /// <inheritdoc />
    public partial class SeedCustomerProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CustomersProducts",
                columns: new[] { "CustomerId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 3, 1, 2 },
                    { 3, 2, 1 },
                    { 4, 5, 1 },
                    { 6, 3, 11 },
                    { 12, 5, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomersProducts",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CustomersProducts",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "CustomersProducts",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "CustomersProducts",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "CustomersProducts",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "CustomersProducts",
                keyColumns: new[] { "CustomerId", "ProductId" },
                keyValues: new object[] { 12, 5 });
        }
    }
}
