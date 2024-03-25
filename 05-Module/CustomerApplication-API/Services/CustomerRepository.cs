namespace CustomerApplication_API.Services
{
    using CustomerApplication_API.Data;
    using CustomerApplication_API.Data.Dtos.Customer;
    using CustomerApplication_API.Data.Entities;
    using CustomerApplication_API.Services.Interfaces;
    using Microsoft.EntityFrameworkCore;

    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerApplicationDbContext _dbContext;

        public CustomerRepository(CustomerApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task CreateAsync(CreateCustomerDto customer)
        {
            var newCustomer = new Customer()
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber,
                Gender = customer.Gender.ToString(),
                Country = customer.Country,
                City = customer.City,
                Birthday = customer.Birthday
            };

            await _dbContext.Customers.AddAsync(newCustomer);

        }

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
