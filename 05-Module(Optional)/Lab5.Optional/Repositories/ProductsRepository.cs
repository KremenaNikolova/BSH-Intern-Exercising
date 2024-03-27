using Lab5.Optional.DbContexts;
using Lab5.Optional.Helpers;
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

        public async Task<IEnumerable<TProduct>> GetSortedListAsync()
        {
            IEnumerable<TProduct> productsList = await _dbSet.ToListAsync();

            IOrderedEnumerable<TProduct> sortedList = null;

            var properties = typeof(TProduct).GetProperties()
                .Where(prop => Attribute.IsDefined(prop, typeof(CustomPriorityAttribute)))
                .OrderBy(prop => prop.GetCustomAttributes<CustomPriorityAttribute>().First().Priority);

            foreach (var property in properties)
            {
                var attributes = property.GetCustomAttribute<CustomPriorityAttribute>();
                var descending = attributes!.IsDescending;

                if (sortedList == null)
                {
                    sortedList = descending
                         ? productsList.OrderByDescending(p => property.GetValue(p))
                         : productsList.OrderBy(p => property.GetValue(p));


                }
                else
                {
                    sortedList = descending
                        ? sortedList.ThenByDescending(p => property.GetValue(p))
                        : sortedList.ThenBy(p => property.GetValue(p));
                }

            }

            return sortedList;
        }

    }
}
