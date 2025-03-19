using ProductsApi.Models;

namespace ProductsApi.Services.utils;

public class ProductValidator
{
    private readonly ISanitizer _sanitizer;

    public ProductValidator(ISanitizer sanitizer)
    {
        _sanitizer = sanitizer;
    }
    
    public Product ValidateProduct(Product product)
    {
        product.Name = _sanitizer.SanitizeString(product.Name);
        product.Price = _sanitizer.ValidateDecimal(product.Price);
        product.Stock = _sanitizer.ValidateInt(product.Stock);
        product.Description = _sanitizer.SanitizeString(product.Description);
        return product;
    }
}