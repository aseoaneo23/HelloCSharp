using ProductsApi.Data.Repositories;
using ProductsApi.Models;
using ProductsApi.Services.utils;

namespace ProductsApi.Services;

public class ProductService
{
    private readonly ProductValidator _productValidator;
    private readonly ProductRepository _productRepository;

    public ProductService(ProductValidator productValidator, ProductRepository productRepository)
    {
        _productValidator = productValidator;
        _productRepository = productRepository;
    }

    public async Task<List<Product>> GetAllProducts()
    {
      var products = await _productRepository.GetAllProducts();

      if (!products.Any())
      {
          return new List<Product>();
      }
      return products;
    }
    
}