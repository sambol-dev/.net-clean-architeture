using System.Net.Http.Headers;
using Clean.Domain.Entities;
using Clean.Domain.Interfaces;

namespace Clean.Application.UseCases.CreateCustomer;

public class CreateCustomerUseCase
{
    private readonly ICustomerRepository _repository;

    public CreateCustomerUseCase(ICustomerRepository repository)
    {
        _repository = repository;
    }

    public async Task ExecuteAsync(string name, string email)
    {
        var customer = new Customer(name, email);
        await _repository.AddAsync(customer);
    }
}
