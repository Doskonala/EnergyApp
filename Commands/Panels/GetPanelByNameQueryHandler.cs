using EnergyApp.Repositories;
using MediatR;
using SolarApi.Models;

namespace EnergyApp.Commands.Panels
{
    public class GetPanelByNameQueryHandler : IRequestHandler<GetPanelByNameQuery, SolarPanel>
    {
        private readonly IPanelRepository categoryRepository;

        public GetPanelByNameQueryHandler(IPanelRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task<SolarPanel> Handle(GetPanelByNameQuery request, CancellationToken cancellationToken)
        {
            return await this.categoryRepository.FindByNameAsync(request.Name);
        }
    }
}
