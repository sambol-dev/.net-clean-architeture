using Clean.Application.UseCases.CreateCustomer;
using Clean.Domain.Interfaces;
using Clean.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<CreateCustomerUseCase>();

var app = builder.Build();

app.MapControllers();

app.Run();
