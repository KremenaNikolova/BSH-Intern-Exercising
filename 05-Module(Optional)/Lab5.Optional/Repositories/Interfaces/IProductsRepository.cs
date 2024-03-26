using Lab5.Optional.Models.Interfaces;

namespace Lab5.Optional.Repositories.Interfaces
{
    public interface IProductsRepository<TProduct> where TProduct : class, IProduct
    {
        Task<IEnumerable<TProduct>> GetProductsAsync();
    }
}
