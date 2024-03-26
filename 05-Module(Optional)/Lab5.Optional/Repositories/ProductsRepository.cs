using Lab5.Optional.DbContexts;
using Lab5.Optional.Models.Interfaces;
using Lab5.Optional.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Lab5.Optional.Repositories
{
    public class ProductsRepository<TProduct> : IProductsRepository<TProduct> where TProduct : class, IProduct
    {
        private ApplicationDbContext _context;
        private DbSet<TProduct> _dbSet;

        public ProductsRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TProduct>();
        }

        public async Task<IEnumerable<TProduct>> GetProductsAsync()
        {
            return await _dbSet.ToListAsync();
        }
    }
}
