using Microsoft.EntityFrameworkCore;
using ProductManagement.Domain.ProductAgg;
using ProductManagement.Domain.ProductCategoryAgg;
using ProductManagement.Domain.ProductPictureAgg;
using ProductManagement.Domain.SlideAgg;
using ProductManagement.Infrastructure.EfCore.Mapping;

namespace ProductManagement.Infrastructure.EfCore
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductPicture> ProductPictures { get; set; }
        public DbSet<Slide> Slides { get; set; }

        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ProductCategoryMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}