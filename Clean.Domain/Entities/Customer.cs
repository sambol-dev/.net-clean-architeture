namespace Clean.Domain.Entities;

public class Customer
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }

    public Customer(string name, string email)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name is required");
        
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
    }
}
