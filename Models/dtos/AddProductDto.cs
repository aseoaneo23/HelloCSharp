namespace ProductsApi.Models.dtos;

public class AddProductDto
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required decimal Price { get; set; }
    public required int Stock { get; set; }
}