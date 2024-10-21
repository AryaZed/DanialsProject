using System.Collections.Generic;
using _0_Framework.Repository;
using ProductManagement.Application.Contract.Slide;

namespace ProductManagement.Domain.SlideAgg
{
    public interface ISlideRepository : IRepository<long, Slide>
    {
        EditSlide GetDetails(long id);
        List<SlideViewModel> GetList();
    }
}
