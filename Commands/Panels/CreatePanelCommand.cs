using MediatR;

namespace EnergyApp.Commands.Panels
{
    public class CreatePanelCommand : IRequest
    {
        public string Name { get; set; }

        public bool IsAvailable { get; set; }

        public int CategoryId { get; set; }
    }
}
