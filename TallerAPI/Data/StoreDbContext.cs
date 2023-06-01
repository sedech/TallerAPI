using TallerAPI.Models;
using TallerAPI.Service;
using Microsoft.EntityFrameworkCore;

namespace TallerAPI.Data
{
    public class StoreDbContext : DbContext
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
      
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { }

        public DbSet<ProductEntity> Products { get; set; }
        //public Dbset<ProductModel> Products { get; set; }  
    }
}
