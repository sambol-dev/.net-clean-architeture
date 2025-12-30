using Clean.Domain.Entities;
using Clean.Domain.Interfaces;

namespace Clean.Infrastructure.Repositories;

public class CustomerRepository : ICustomerRepository
{
    public async Task AddAsync(Customer customer)
    {
        Console.WriteLine($"Customer saved: {customer.Name}");
        await Task.CompletedTask;
    }
}
