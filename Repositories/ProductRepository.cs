using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using ProductsApi.Models;

namespace ProductsApi.Data.Repositories;

public class ProductRepository
{
    private readonly AppDbContext _dbContext;
    private readonly ILogger<ProductRepository> _logger;

    public ProductRepository(AppDbContext dbContext, ILogger<ProductRepository> logger)
    {
        _dbContext = dbContext;
        _logger = logger;
    }

    public async Task<List<Product>> GetAllProducts() => await _dbContext.Products.ToListAsync();

    public bool AddProduct(Product product)
    {
        try
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            _logger.LogError( "The product ${product} cannot be added because exception: ${ex}:", ex.Message);
            return false;
        }
    }
}