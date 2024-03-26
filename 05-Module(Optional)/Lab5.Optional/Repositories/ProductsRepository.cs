using Lab5.Optional.DbContexts;
using Lab5.Optional.Models.Interfaces;
using Lab5.Optional.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Reflection;

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

        public async Task<IEnumerable<TProduct>> GetAscendingSortedListAsync(string propertyName)
        {
            var producstList = await _dbSet.ToListAsync();

            var property = typeof(TProduct).GetProperty(propertyName);

            if (property == null)
            {
                return Enumerable.Empty<TProduct>();
            }

            var sortedList = producstList
                .OrderBy(product => property!.GetValue(product));

            return sortedList;
        }


        public async Task<IEnumerable<TProduct>> GetDescendingSortedListAsync(string propertyName)
        {
            var producstList = await _dbSet.ToListAsync();

            var property = typeof(TProduct).GetProperty(propertyName);

            if (property == null)
            {
                return Enumerable.Empty<TProduct>();
            }

            var sortedList = producstList
                .OrderByDescending(product => property!.GetValue(product));

            return sortedList;
        }
    }
}
