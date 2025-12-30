using Clean.Domain.Entities;

namespace Clean.Domain.Interfaces;

public interface ICustomerRepository
{
    Task AddAsync(Customer customer);
}
