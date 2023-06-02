using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TallerAPI.Models;
using TallerAPI.Service;

namespace TallerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService) 
        {
            this._productService = productService;
        }

        [HttpGet]
          public IActionResult GetAllProduct() 
          {
             List<ProductEntity> product = this._productService.GetAllProducts();
             return Ok(product); 
          }
                                                                   
        [HttpPost]
        public IActionResult CreateProduct([FromBody] ProductModel product)
        {
            _productService.CreateProduct(product);
            return Ok(); //Ok devolver un cod 200
        }
        
        [HttpDelete]
        public IActionResult DeleteProduct([FromQuery] int id)
        {
            _productService.DeleteProduct(id);
            return Ok();
        }

        [HttpGet]
        [Route("getProduct/{id}")]
        public IActionResult GetProduct(int id)
        {
            ProductEntity product = _productService.GetProductById(id);  
            return Ok(product);
        }
        
    }
}
