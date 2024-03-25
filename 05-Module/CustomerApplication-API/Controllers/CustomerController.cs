namespace CustomerApplication_API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    
    using CustomerApplication_API.Data.Entities;
    using CustomerApplication_API.Services.Interfaces;

    using static CustomerApplication_API.Commons.ValidationConstants.PageValidation;
    using System.Text.Json;

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
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomersByCountry(string? country, int pageNumber = PageDefault, int pageSize = MaxPageSize)
        {
            if (pageSize > MaxPageSize)
            {
                pageSize = MaxPageSize;
            }

            var (customers, paginationMetadata) = await _customerService.GetCustomerByCountryAsync(country, pageNumber, pageSize);

            if (customers == null)
            {
                return NotFound();
            }

            Response.Headers.Append("Pagination", JsonSerializer.Serialize(paginationMetadata));

            return Ok(customers);
        }
    }
}
