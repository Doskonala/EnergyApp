using MediatR;

namespace EnergyApp.Commands.Panels
{
    public class UpdatePanelCommand : IRequest
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsAvailable { get; set; }

        public int CategoryId { get; set; }
    }
}
