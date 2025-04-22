using sky_webapi.Data.Entities;

namespace sky_webapi.Repositories
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<CustomerEntity>> GetCustomersAsync();
        Task<CustomerEntity?> GetCustomerAsync(int id);
        Task AddCustomerAsync(CustomerEntity customer);
        Task UpdateCustomerAsync(CustomerEntity customer);
        Task DeleteCustomerAsync(int id);
        Task<bool> CustomerExistsAsync(int id);
    }
}
