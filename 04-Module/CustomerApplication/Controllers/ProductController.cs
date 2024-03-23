namespace CustomerApplication.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    
    using X.PagedList;
    
    using CustomerApplication.Services.Interfaces;

    using static CustomerApplication.Commons.ValidationConstants;
    

    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICustomerService _customerService;

        public ProductController(IProductService productService, ICustomerService customerService)
        {
            _productService = productService;
            _customerService = customerService;
        }

        public IActionResult All(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = PageValidation.pageSize;

            try
            {
                var allProducts = _productService.GetAllProductsQuery().ToPagedList(pageNumber, pageSize);
                return View(allProducts);
            }
            catch
            {
                return RedirectToAction("All", "Home");
            }
        }

        public IActionResult AllCustomerProducts(int id, int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = PageValidation.pageSize;

            try
            {
                var customerProducts = _customerService
                .GetCustomerProductsQuery(id).ToPagedList(pageNumber, pageSize);
                return View(customerProducts);
            }
            catch
            {
                return RedirectToAction("All", "Home");
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> Delete (int customerId, int productId)
        {
            try
            {
                await _customerService.DeleteCustomerProductAsync(customerId, productId);
            }
            catch
            {
                return RedirectToAction("All", "Home");
            }

            return RedirectToAction("All", "Home");
        }
    }
}
