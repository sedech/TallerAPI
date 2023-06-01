using System;
using System.Threading.Tasks;
using TallerAPI.Data;
using TallerAPI.Models;

namespace TallerAPI.Service
{
    public class ProductService : IProductService
    {
        private readonly StoreDbContext _context;
        

        public ProductService(StoreDbContext context)
        {
            this._context = context;
        }
        public StoreDbContext Get_Context()
        {
            return _context;
        }

        // crud

        public void CreateProduct(ProductModel product)
        {
            ProductEntity productEntity = new()
            {
                Name = product.Name,
                Description = product.Description,
                Stock = product.Stock,
                CreateDate = DateTime.Now
            };
            _context.Products.Add(productEntity);
            _context.SaveChanges(); //guardar los cambios en BD
        }


        public void DeleteProduct(int id)
        {
            ProductEntity productToDelete = this.GetProductById(id);    
            _context.Products.Remove(productToDelete);
        }
        public ProductEntity GetProductById(int id)
        {
            return _context.Products.Find(id);
        }
        public List<ProductEntity> GetAllProducts()
        {
            
            return _context.Products.ToList();
        }






    }
}
