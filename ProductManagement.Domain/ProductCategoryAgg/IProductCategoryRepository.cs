﻿using System.Collections.Generic;
using _0_Framework.Repository;
using ProductManagement.Application.Contract.ProductCategory;

namespace ProductManagement.Domain.ProductCategoryAgg
{
    public interface IProductCategoryRepository : IRepository<long, ProductCategory>
    {
        List<ProductCategoryViewModel> GetProductCategories();
        EditProductCategory GetDetails(long id);
        string GetSlugById(long id);
        List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel);
    }
}
