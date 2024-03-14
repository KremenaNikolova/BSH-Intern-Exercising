namespace CustomerApplication.Services
{
    using System.Threading.Tasks;
    
    using CustomerApplication.Data;
    using CustomerApplication.Data.Model;
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
    }
}
