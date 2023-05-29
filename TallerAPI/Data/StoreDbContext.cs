using TallerAPI.Models;
using TallerAPI.Service;
using Microsoft.EntityFrameworkCore;

namespace TallerAPI.Data
{
    public class StoreDbContext : DbContext
    {
        public class Dbset<T>
        {
            internal ProductModel Find(int id)
            {
                throw new NotImplementedException();
            }

            internal void Remove(ProductModel productToDelete)
            {
                throw new NotImplementedException();
            }

            internal void Remove(ProductEntity productToDelete)
            {
                throw new NotImplementedException();
            }

            internal List<ProductModel> ToList()
            {
                throw new NotImplementedException();
            }
        }
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { }

        public Dbset<ProductEntity> Product { get; set; }
        public Dbset<ProductModel> Products { get; set; }  
    }
}
