using AutoMapper;
using XML_Dependency.Models;

namespace XML_Dependency.Mapping
{
    public class FoodMapping : Profile
    {
        public FoodMapping()
        {
            CreateMap<Food, FoodDto>().ReverseMap();
        }
    }
}
