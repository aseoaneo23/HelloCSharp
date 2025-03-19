namespace ProductsApi.Models;

public class Product
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required decimal Price { get; set; }
    public required int Stock { get; set; }
    public required string Description { get; set; }

    public Product(string name, decimal price, int stock, string description)
    {
        Id = Guid.NewGuid();
        Name = name;
        Price = price;
        Stock = stock;
        Description = description;
    }
}