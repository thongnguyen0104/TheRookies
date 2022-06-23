using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Economic.Data.Entities;
using Economic.Data.Configurations;

namespace Economic.Data.EF
{
    public class EconomicDbContext : DbContext
    {
        public EconomicDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API in config file
            modelBuilder
                .ApplyConfiguration(new OrderConfiguration())
                .ApplyConfiguration(new CartConfiguration())
                .ApplyConfiguration(new OrderDetailConfiguration())
                .ApplyConfiguration(new ProductConfiguration())
                .ApplyConfiguration(new RoleConfiguration())
                .ApplyConfiguration(new ProductTypeConfiguration())
                .ApplyConfiguration(new CommentConfiguration())
                .ApplyConfiguration(new ProductImageConfiguration());

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }
    }
}
