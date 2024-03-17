namespace CustomerApplication.Services.Interfaces
{
    using CustomerApplication.ViewModels.Home;

    public interface ICustomerService
    {
        Task AddCustomerAsync(CustomerForm customerForm);

        IQueryable<CustomerForm> GetAllCustomersQuery();

        Task<bool> IsUserWithThisEmailExisAsync(string email);
    }
}
