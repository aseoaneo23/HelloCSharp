namespace ProductsApi.Models;

public class User
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public string ? FirstName { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public DateTime InsertDate { get; set; } = DateTime.Now;
    public required string Role { get; set; }
}