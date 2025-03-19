using System.Text.Json.Serialization;
using System.Xml;
using Microsoft.AspNetCore.Mvc;
using ProductsApi.Data;
using ProductsApi.Models;
using ProductsApi.Models.dtos;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;


namespace ProductsApi.Controllers
{
    //localhost:5186/api/products
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext dbContext;
        
        public ProductsController(AppDbContext dbContext)
        {  
            this.dbContext = dbContext;
        }
        
        [Route("getAllProducts")]
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var allProducts = dbContext.Products.ToList();
            return Ok(allProducts);
        }
        [Route("addProducts")]
        [HttpPost]
        public IActionResult AddProduct(AddProductDto productDto)
        {
            var productEntity = new Product()
            {
                Name = productDto.Name,
                Price = productDto.Price,
                Stock = productDto.Stock
            };
            dbContext.Products.Add(productEntity);
            dbContext.SaveChanges();

            string productResult = JsonConvert.SerializeObject(productEntity, Formatting.Indented);
            return Ok($"The product\n {productResult}\n has been added");
        }
    }
}

