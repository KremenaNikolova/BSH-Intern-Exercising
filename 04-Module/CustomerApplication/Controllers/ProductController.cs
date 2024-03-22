namespace CustomerApplication.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    
    using X.PagedList;
    
    using CustomerApplication.Services.Interfaces;

    using static CustomerApplication.Commons.ValidationConstants;
    

    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
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
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
