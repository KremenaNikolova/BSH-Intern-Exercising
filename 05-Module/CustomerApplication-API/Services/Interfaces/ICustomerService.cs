namespace CustomerApplication_API.Services.Interfaces
{
    using CustomerApplication_API.Data.Entities;
    using System.Drawing.Printing;

    public interface ICustomerService
    {
        Task<Customer?> GetCustomerByIdAsync(int id);

        Task<IEnumerable<Customer>> GetCustomerByCountryAsync(string? country, int pageNumber, int pageSize);
    }
}
