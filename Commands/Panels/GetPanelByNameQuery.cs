using MediatR;
using SolarApi.Models;

namespace EnergyApp.Commands.Panels
{
    public class GetPanelByNameQuery : IRequest<SolarPanel>
    {
        public string Name { get; set; }
    }
}
