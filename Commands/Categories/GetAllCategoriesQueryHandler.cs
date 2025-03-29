using EnergyApp.Models;
using EnergyApp.Repositories;
using MediatR;

namespace EnergyApp.Commands.Categories
{
    public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, List<Category>>
    {
        private readonly ICategoryRepository categoryRepository;

        public GetAllCategoriesQueryHandler(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task<List<Category>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            var categories = await categoryRepository.GetAllAsync();

            return categories;
        }
    }
}
