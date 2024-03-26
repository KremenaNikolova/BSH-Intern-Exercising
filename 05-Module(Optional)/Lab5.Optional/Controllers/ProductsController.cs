using Lab5.Optional.Models.Interfaces;
using Lab5.Optional.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Security.Cryptography;

namespace Lab5.Optional.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class ProductsController<TProduct> : ControllerBase where TProduct : class, IProduct
    {
        private readonly IProductsRepository<TProduct> _productsRepository;

        protected ProductsController(IProductsRepository<TProduct> productsRepository)
        {
            _productsRepository = productsRepository;
        }

        [Route("list")]
        public virtual async Task<IActionResult> GetList()
        {
            var result = await _productsRepository.GetProductsAsync();
            return Ok(result);
        }

        [Route("list/sort")]
        public async Task<IActionResult> SortProducts(string propertyName)
        {
            var sortedList = await _productsRepository.GetAscendingSortedListAsync(propertyName);

            if (sortedList.Count() == 0)
            {
                return NotFound();
            }

            return Ok(sortedList);

        }
    }
}
