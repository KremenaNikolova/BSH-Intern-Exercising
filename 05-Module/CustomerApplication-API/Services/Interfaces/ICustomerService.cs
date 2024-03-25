namespace CustomerApplication_API.Services.Interfaces
{
    using CustomerApplication_API.Data.Entities;

    public interface ICustomerService
    {
        Task<Customer?> GetCustomerByIdAsync(int id);

    }
}
