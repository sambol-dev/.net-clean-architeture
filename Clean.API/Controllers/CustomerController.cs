using Clean.Application.UseCases.CreateCustomer;
using Microsoft.AspNetCore.Mvc;

namespace Clean.API.Controllers;

[ApiController]
[Route("api/customers")]
public class CustomerController : ControllerBase
{
    private readonly CreateCustomerUseCase _useCase;

    public CustomerController(CreateCustomerUseCase useCase)
    {
        _useCase = useCase;
    }

    [HttpPost]
    public async Task<IActionResult> Post(CreateCustomerRequest request)
    {
        await _useCase.ExecuteAsync(request.Name, request.Email);
        return Ok();
    }
}

public record CreateCustomerRequest(string Name, string Email);