namespace CustomerApplication.Services
{
    using System.Threading.Tasks;
    
    using CustomerApplication.Data;
    using CustomerApplication.Data.Models;
    using CustomerApplication.Services.Interfaces;
    using CustomerApplication.ViewModels.Home;

    public class CustomerService : ICustomerService
    {
        private readonly CustomerApplicationDbContext _dbContext;

        public CustomerService(CustomerApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddCustomerAsync(CustomerForm customerForm)
        {
            Customer customer = new Customer()
            {
                FirstName = customerForm.FirstName,
                LastName = customerForm.LastName,
                Email = customerForm.Email,
                PhoneNumber = customerForm.PhoneNumber,
                Gender = customerForm.Gender.ToString(),
                Country = customerForm.Country,
                City = customerForm.City,
                Birthday = customerForm.Birthday
            };

            await _dbContext.Customers.AddAsync(customer);
            await _dbContext.SaveChangesAsync();
        }

        public IQueryable<CustomerForm> GetAllCustomersQuery()
        {
            var allCustomers = _dbContext
                .Customers
                .Select(c => new CustomerForm()
                {
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Email = c.Email,
                    PhoneNumber = c.PhoneNumber,
                    Country = c.Country,
                    City = c.City,
                    Birthday = c.Birthday
                })
                .AsQueryable();

            return allCustomers;
        }
    }
}
