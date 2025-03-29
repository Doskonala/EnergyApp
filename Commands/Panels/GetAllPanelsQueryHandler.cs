using EnergyApp.Repositories;
using MediatR;
using SolarApi.Models;

namespace EnergyApp.Commands.Panels
{
    public class GetAllPanelsQueryHandler : IRequestHandler<GetAllPanelsQuery, List<SolarPanel>>
    {
        private readonly IPanelRepository categoryRepository;

        public GetAllPanelsQueryHandler(IPanelRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task<List<SolarPanel>> Handle(GetAllPanelsQuery request, CancellationToken cancellationToken)
        {
            var categories = await categoryRepository.GetAllAsync();

            return categories;
        }
    }
}
