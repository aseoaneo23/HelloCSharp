namespace ProductsApi.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string FirstName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime InsertDate { get; set; } = DateTime.Now;
    public string Role { get; set; }
}