using TallerAPI.Data;
using TallerAPI.Models;

namespace TallerAPI.Service
{
    public interface IProductService
    {
        void CreateProduct(ProductModel product);
        void DeleteProduct(int id);
        List<ProductEntity> GetAllProducts();
        ProductEntity GetProductById(int id);
        //StoreDbContext Get_Context();
    }
}