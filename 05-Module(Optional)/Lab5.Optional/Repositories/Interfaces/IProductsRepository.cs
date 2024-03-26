using Lab5.Optional.Models.Interfaces;

namespace Lab5.Optional.Repositories.Interfaces
{
    public interface IProductsRepository<TProduct> where TProduct : class, IProduct
    {
        Task<IEnumerable<TProduct>> GetProductsAsync();

        Task<IEnumerable<TProduct>> GetAscendingSortedListAsync(string propertyName);

        Task<IEnumerable<TProduct>> GetDescendingSortedListAsync(string propertyName);
    }
}
