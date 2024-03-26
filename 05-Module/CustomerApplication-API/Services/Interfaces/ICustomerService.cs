namespace CustomerApplication_API.Services.Interfaces
{
    using CustomerApplication_API.Data.Dtos.Customer;
    using CustomerApplication_API.Data.Entities;

    public interface ICustomerService
    {
        Task<Customer?> GetCustomerByIdAsync(int id);

        Task<(IEnumerable<Customer>, PaginationMetadata)> GetCustomerByCountryAsync(string? country, int pageNumber, int pageSize);

        Task<CustomerPhoneNumber?> GetCustomerPhoneNumber(int id);
    }
}
