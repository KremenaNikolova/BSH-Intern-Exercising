namespace CustomerApplication.Services.Interfaces
{
    using CustomerApplication.ViewModels.Home;
    using CustomerApplication.ViewModels.Product;

    public interface ICustomerService
    {
        Task AddCustomerAsync(CustomerForm customerForm);

        IQueryable<CustomerForm> GetAllCustomersQuery();

        Task<bool> IsUserWithThisEmailExisAsync(string email);

        Task<IEnumerable<CustomerProducts>> GetCustomerProductsAsync(int id);

        IQueryable<CustomerProducts> GetCustomerProductsQuery(int id);
    }
}
