using _01_ProjectQuery.Contract.Product;
using _01_ProjectQuery.Contract.ProductCategory;
using _01_ProjectQuery.Contract.Slide;
using _01_ProjectQuery.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductManagement.Application;
using ProductManagement.Application.Contract.Product;
using ProductManagement.Application.Contract.ProductCategory;
using ProductManagement.Application.Contract.ProductPicture;
using ProductManagement.Application.Contract.Slide;
using ProductManagement.Domain.ProductAgg;
using ProductManagement.Domain.ProductCategoryAgg;
using ProductManagement.Domain.ProductPictureAgg;
using ProductManagement.Domain.SlideAgg;
using ProductManagement.Infrastructure.EfCore;
using ProductManagement.Infrastructure.EfCore.Repository;

namespace ProductManagement.Configuration
{
    public class ProductManagementBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IProductCategoryApplication, ProductCategoryApplication>();
            services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();

            services.AddTransient<IProductApplication, ProductApplication>();
            services.AddTransient<IProductRepository, ProductRepository>();

            services.AddTransient<IProductPictureApplication, ProductPictureApplication>();
            services.AddTransient<IProductPictureRepository, ProductPictureRepository>();

            services.AddTransient<ISlideApplication, SlideApplication>();
            services.AddTransient<ISlideRepository, SlideRepository>();


            services.AddTransient<ISlideQuery, SlideQuery>();
            services.AddTransient<IProductCategoryQuery, ProductCategoryQuery>();
            services.AddTransient<IProductQuery, ProductQuery>();

            services.AddDbContext<ProductContext>(x => x.UseSqlServer(connectionString));
        }
    }
}