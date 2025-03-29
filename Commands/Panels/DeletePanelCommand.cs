using MediatR;

namespace EnergyApp.Commands.Panels
{
    public class DeletePanelCommand : IRequest
    {
        public int Id { get; set; }
    }
}
