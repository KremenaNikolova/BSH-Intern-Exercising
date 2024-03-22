namespace CustomerApplication.Services.Interfaces
{
    using CustomerApplication.ViewModels.Product;

    public interface IProductService
    {
        IQueryable<ProductForm> GetAllProductsQuery();
    }
}
