namespace CustomerApplication_API.Controllers
{
    using CustomerApplication_API.Data.Entities;
    using CustomerApplication_API.Services.Interfaces;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<ActionResult<Customer>> GetCustomerById(int id)
        {
            var customer = await _customerService.GetCustomerByIdAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        [HttpGet("{country}")]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomersByCountry(string country)
        {
            var customer = await _customerService.GetCustomerByCountryAsync(country);

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }
    }
}
