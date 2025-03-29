using AutoMapper;
using EnergyApp.Models;
using EnergyApp.ViewModels.Panel;
using SolarApi.Models;

namespace EnergyApp.Mapping
{
    public class PanelProfile : Profile
    {
        public PanelProfile()
        {
            CreateMap<CreatePanelViewModel, SolarPanel>();
            CreateMap<UpdatePanelViewModel, SolarPanel>();

            CreateMap<SolarPanel, PanelListViewModel>()
                .ForMember(panelListViewModel => panelListViewModel.CategoryName, option => option.MapFrom(panel => panel.Category.Title));

            CreateMap<SolarPanel, PanelDetailsViewModel>()
                .ForMember(panelListViewModel => panelListViewModel.CategoryName, option => option.MapFrom(panel => panel.Category.Title));
        }
    }
}
