using EnergyApp.Repositories;
using MediatR;
using SolarApi.Models;

namespace EnergyApp.Commands.Panels
{
    public class UpdatePanelCommandHandler : IRequestHandler<UpdatePanelCommand>
    {
        private readonly IPanelRepository categoryRepository;

        public UpdatePanelCommandHandler(IPanelRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task Handle(UpdatePanelCommand request, CancellationToken cancellationToken)
        {
            var category = new SolarPanel
            {
                Id = request.Id,
                Name = request.Name,
                IsAvailable = request.IsAvailable,
                CategoryId = request.CategoryId
            };

            await categoryRepository.UpdateAsync(category);
        }
    }
}
