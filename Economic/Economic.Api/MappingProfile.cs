using AutoMapper;
using Economic.Data.Entities;
using Economic.ViewModels.ViewModels;

namespace Economic.Api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductViewModel>();
        }
    }
}
