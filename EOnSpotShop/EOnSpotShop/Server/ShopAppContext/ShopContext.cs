using Microsoft.EntityFrameworkCore;

namespace EOnSpotShop.Server.ShopAppContext
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
