namespace CustomerApplication_API.Services
{
    using System.Threading.Tasks;
    
    using Microsoft.EntityFrameworkCore;
    
    using CustomerApplication_API.Data;
    using CustomerApplication_API.Data.Entities;
    using CustomerApplication_API.Services.Interfaces;
    using CustomerApplication_API.Data.Dtos.Customer;

    public class CustomerService : ICustomerService
    {
        private readonly CustomerApplicationDbContext _dbContext;

        public CustomerService(CustomerApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Customer?> GetCustomerByIdAsync(int id)
        {
            var customer = await _dbContext
                .Customers
                .Where(c => c.Id == id)
                .FirstOrDefaultAsync();

            return customer;
        }

        public async Task<(IEnumerable<Customer>, PaginationMetadata)> GetCustomerByCountryAsync(string? country, int pageNumber, int pageSize)
        {
            var customerQuery = _dbContext
                .Customers
                .Where (c => c.Country == country)
                .AsQueryable();

            var customerPagination = await customerQuery
                .Skip(pageSize * (pageNumber - 1))
                .Take(pageSize)
                .ToListAsync();

            var totalItemsCount = customerPagination.Count;
            var paginationMetadata = new PaginationMetadata(totalItemsCount, pageSize, pageNumber);

            return (customerPagination, paginationMetadata);
        }

        public async Task<CustomerPhoneNumber?> GetCustomerPhoneNumber(int id)
        {
            var phoneNumber = await _dbContext
                .Customers
                .Where(c=>c.Id == id)
                .Select(c => new CustomerPhoneNumber()
                {
                    Id = c.Id,
                    PhoneNumber = c.PhoneNumber
                })
                .FirstOrDefaultAsync();

            return phoneNumber;
        }
    }
}
