using MediatR;
using SolarApi.Models;

namespace EnergyApp.Commands.Panels
{
    public class GetAllPanelsQuery : IRequest<List<SolarPanel>>
    {
    }
}
