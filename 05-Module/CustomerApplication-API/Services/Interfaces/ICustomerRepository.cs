namespace CustomerApplication_API.Services.Interfaces
{
    using CustomerApplication_API.Data.Dtos.Customer;

    public interface ICustomerRepository
    {
        Task CreateAsync(CreateCustomerDto customer);

        Task SaveAsync();
    }
}
