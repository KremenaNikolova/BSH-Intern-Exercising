namespace CustomerApplication.Controllers
{
    using CustomerApplication.Services.Interfaces;
    using CustomerApplication.ViewModels;
    using CustomerApplication.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;
    using System.Diagnostics;

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
        public async Task<IActionResult> Index(CustomerForm customer)
        {
            if(!ModelState.IsValid)
            {
                return View(customer);
            }

            try
            {
                await _customerService.AddCustomerAsync(customer);
            }
            catch (Exception ex)
            {
                Console.WriteLine("pak obyrkah");
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
