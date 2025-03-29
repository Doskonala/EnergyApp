using EnergyApp.Repositories;
using MediatR;

namespace EnergyApp.Commands.Panels
{
    public class DeletePanelCommandHandler : IRequestHandler<DeletePanelCommand>
    {
        private readonly IPanelRepository categoryRepository;

        public DeletePanelCommandHandler(IPanelRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task Handle(DeletePanelCommand request, CancellationToken cancellationToken)
        {
            await categoryRepository.DeleteAsync(request.Id);
        }
    }
}
