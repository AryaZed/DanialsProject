﻿using System.Collections.Generic;
using _0_Framework.Repository;
using ProductManagement.Application.Contract.ProductPicture;

namespace ProductManagement.Domain.ProductPictureAgg
{
    public interface IProductPictureRepository : IRepository<long, ProductPicture>
    {
        EditProductPicture GetDetails(long id);
        ProductPicture GetWithProductAndCategory(long id);
        List<ProductPictureViewModel> Search(ProductPictureSearchModel searchModel);
    }
}
