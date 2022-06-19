using EShop.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EShop.Data.EF
{
    public class EShopDbContext : DbContext
    {
        public EShopDbContext(DbContextOptions<EShopDbContext> options)
        : base(options)
        {
        }

       public DbSet<Student> Students { get; set; }
    }
}
