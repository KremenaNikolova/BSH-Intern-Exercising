namespace CustomerApplication.Controllers
{
    using System.Diagnostics;
    
    using Microsoft.AspNetCore.Mvc;
    
    using CustomerApplication.Services.Interfaces;
    using CustomerApplication.ViewModels;
    using CustomerApplication.ViewModels.Home;

    public class HomeController : Controller
    {
        private readonly ICustomerService _customerService;

        public HomeController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public IActionResult Index()
        {
            return  View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CustomerForm customerModel)
        {
            if(!ModelState.IsValid)
            {
                return View(customerModel);
            }

            try
            {
                await _customerService.AddCustomerAsync(customerModel);
            }
            catch (Exception)
            {
                return View(customerModel);
            }

            return RedirectToAction("Index", "Home");

        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
