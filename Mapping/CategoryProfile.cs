using AutoMapper;
using EnergyApp.Models;
using EnergyApp.ViewModels.Category;

namespace EnergyApp.Mapping
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            CreateMap<CreateCategoryViewModel, Category>();
            CreateMap<UpdateCategoryViewModel, Category>();

            CreateMap<Category, CategoryListViewModel>();

            CreateMap<Category, CategoryDetailsViewModel>();
        }
    }
}
