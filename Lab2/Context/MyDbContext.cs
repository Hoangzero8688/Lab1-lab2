using Lab2.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {

        }

        public MyDbContext()
        {
                
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Color> Colors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductDetail>()
                .HasOne(pd => pd.Product)
                .WithMany(p => p.Details)
                .HasForeignKey(pd => pd.ProductId);

            modelBuilder.Entity<ProductDetail>()
                .HasOne(pd => pd.Size)
                .WithMany()
                .HasForeignKey(pd => pd.SizeId);

            modelBuilder.Entity<ProductDetail>()
                .HasOne(pd => pd.Color)
                .WithMany()
                .HasForeignKey(pd => pd.ColorId);
        }

    }
}
