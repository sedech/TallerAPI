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
        public IActionResult CreateProduct(ProductModel product)
        {
            _productService.CreateProduct(product);
            return Ok(); //Ok devolver un cod 200
        }

    }
}
