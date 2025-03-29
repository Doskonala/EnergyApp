using MediatR;
using SolarApi.Models;

namespace EnergyApp.Commands.Panels
{
    public class GetPanelQuery : IRequest<SolarPanel>
    {
        public int Id { get; set; }
    }
}
