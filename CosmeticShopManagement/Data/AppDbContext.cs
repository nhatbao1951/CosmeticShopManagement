using CosmeticShopManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Reflection;

namespace CosmeticShopManagement.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner_Product>().HasKey(op => new
            {
                op.OwnerId,
                op.ProductId
            });

            modelBuilder.Entity<Owner_Product>().HasOne(p => p.Product).WithMany(op => op.OwnerProducts).HasForeignKey(p => p.ProductId);
            modelBuilder.Entity<Owner_Product>().HasOne(p => p.Owner).WithMany(op => op.Owner_Products).HasForeignKey(p => p.OwnerId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Owner_Product> Owner_Products { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}