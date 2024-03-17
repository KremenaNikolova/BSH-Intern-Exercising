namespace CustomerApplication.Controllers
{
    using System.Diagnostics;

    using Microsoft.AspNetCore.Mvc;

    using CustomerApplication.Services.Interfaces;
    using CustomerApplication.ViewModels;
    using CustomerApplication.ViewModels.Home;
    
    using static CustomerApplication.Commons.ValidationConstants;

    using X.PagedList;

    public class HomeController : Controller
    {
        private readonly ICustomerService _customerService;

        public HomeController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CustomerForm customerModel)
        {
            try
            {
                bool isUserEmailExist = await _customerService
                    .IsUserWithThisEmailExisAsync(customerModel.Email);

                if (isUserEmailExist)
                {
                    ModelState.AddModelError(nameof(customerModel.Email), CustomerConstants.EmailAlreadyExist);
                }

                if (!ModelState.IsValid)
                {
                    return View(customerModel);
                }

                await _customerService.AddCustomerAsync(customerModel);
            }
            catch (Exception)
            {
                return View(customerModel);
            }

            return RedirectToAction("Index", "Home");

        }

        public IActionResult All(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = PageValidation.pageSize;

            try
            {
                var allCustomers = _customerService.GetAllCustomersQuery().ToPagedList(pageNumber, pageSize);
                return View(allCustomers);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
            
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
