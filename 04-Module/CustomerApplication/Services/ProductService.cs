namespace CustomerApplication.Services
{
    using CustomerApplication.Data;
    using CustomerApplication.Services.Interfaces;
    using CustomerApplication.ViewModels.Product;
    using System.Linq;

    public class ProductService : IProductService
    {
        private readonly CustomerApplicationDbContext _dbContext;

        public ProductService(CustomerApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<ProductForm> GetAllProductsQuery()
        {
            var allProducts = _dbContext
                .Products
                .Select(p => new ProductForm
                {
                    Name = p.Name,
                    Category = p.Category.Name,
                    Price = p.Price,
                    Quantity = p.Quantity,
                })
                .AsQueryable();

            return allProducts;
        }
    }
}
