using Microsoft.AspNetCore.Mvc;
using ProductsApi.Models;
using ProductsApi.Models.dtos;
using Newtonsoft.Json;
using ProductsApi.Services;
using Formatting = Newtonsoft.Json.Formatting;


namespace ProductsApi.Controllers
{
    //localhost:5186/api/products
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService productService;

        public ProductsController(ProductService productService)
        {
            this.productService = productService;
        }
        
        
        [Route("getAllProducts")]
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var productsResult = await productService.GetAllProducts();
            if (!productsResult.Any())
            {
                return Ok("There are no products to show");
            }
            return Ok(productsResult);
        }
        
        // [Route("addProducts")]
        // [HttpPost]
        // public IActionResult AddProduct(AddProductDto productDto)
        // {
        //     var productEntity = new Product()
        //     {
        //         Name = productDto.Name,
        //         Price = productDto.Price,
        //         Stock = productDto.Stock,
        //         Description = productDto.Description,
        //     };
        //     dbContext.Products.Add(productEntity);
        //     dbContext.SaveChanges();
        //
        //     string productResult = JsonConvert.SerializeObject(productEntity, Formatting.Indented);
        //     return Ok($"The product\n {productResult}\n has been added");
        // }
    }
}

