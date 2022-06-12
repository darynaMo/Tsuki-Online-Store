using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TsukiStore.Models;

namespace TsukiStore.Data
{
    public class AppDbContext:DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand_Product>().HasKey(bp => new
            {
                bp.BrandId,
                bp.ProductId
            });

            modelBuilder.Entity<Brand_Product>().HasOne(m => m.Продукт).WithMany(bp => bp.Бренд_Продукт).HasForeignKey(m => m.ProductId);

            modelBuilder.Entity<Brand_Product>().HasOne(m => m.Бренд).WithMany(bp => bp.Бренд_Продукт).HasForeignKey(m => m.BrandId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand_Product> Brands_Products { get; set; }
    }
}
