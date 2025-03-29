using MediatR;
using EnergyApp.Models;
using EnergyApp.Repositories;
using SolarApi.Models;

namespace EnergyApp.Commands.Panels
{
    public class CreatePanelCommandHandler : IRequestHandler<CreatePanelCommand>
    {
        private readonly IPanelRepository categoryRepository;

        public CreatePanelCommandHandler(IPanelRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task Handle(CreatePanelCommand request, CancellationToken cancellationToken)
        {
            var category = new SolarPanel
            {
                Name = request.Name,
                IsAvailable = request.IsAvailable,
                CategoryId = request.CategoryId
            };

            await categoryRepository.AddAsync(category);
        }
    }
}
