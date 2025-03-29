using EnergyApp.Repositories;
using MediatR;
using SolarApi.Models;

namespace EnergyApp.Commands.Panels
{
    public class GetPanelQueryHandler : IRequestHandler<GetPanelQuery, SolarPanel>
    {
        private readonly IPanelRepository categoryRepository;

        public GetPanelQueryHandler(IPanelRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task<SolarPanel> Handle(GetPanelQuery request, CancellationToken cancellationToken)
        {
            return await this.categoryRepository.FindAsync(request.Id);
        }
    }
}
