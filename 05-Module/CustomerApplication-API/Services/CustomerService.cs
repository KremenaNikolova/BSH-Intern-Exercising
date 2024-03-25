namespace CustomerApplication_API.Services
{
    using CustomerApplication_API.Data;
    using CustomerApplication_API.Data.Entities;
    using CustomerApplication_API.Services.Interfaces;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

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

    }
}
