namespace CustomerApplication_API.Controllers
{
    using System.Text.Json;
    
    using Microsoft.AspNetCore.Mvc;
    
    using CustomerApplication_API.Data.Dtos.Customer;
    using CustomerApplication_API.Data.Entities;
    using CustomerApplication_API.Services.Interfaces;

    using static CustomerApplication_API.Commons.ValidationConstants.PageValidation;
    using static CustomerApplication_API.Commons.NotificationMessages.CustomerNotifications;

    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerService customerService, ICustomerRepository customerRepository)
        {
            _customerService = customerService;
            _customerRepository = customerRepository;
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

        [HttpPost("new")]
        public async Task<ActionResult> AddNewCustomer([FromBody] CreateCustomerDto newCustomer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _customerRepository.CreateAsync(newCustomer);
            await _customerRepository.SaveAsync();

            return Ok(CreateUserSuccessful);
        }

        [HttpGet("udate")]
        public async Task<ActionResult> UpadteCustomerPhoneNumber(int id)
        {
            var phoneNumber = await _customerService
                .GetCustomerPhoneNumber(id);

            if (phoneNumber == null)
            {
                return BadRequest();
            }

            return Ok(phoneNumber);

        }

        [HttpPut("update")]
        public async Task<ActionResult> UpadteCustomerPhoneNumber([FromBody]CustomerPhoneNumber phoneNumber)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _customerRepository.UpdatePhoneNumberAsync(phoneNumber);
            await _customerRepository.SaveAsync();

            return Ok(UpdatePhoneNumberSuccessful);
        }
    }
}
