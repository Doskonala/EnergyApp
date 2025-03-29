using EnergyApp.Models;
using EnergyApp.Repositories;
using MediatR;

namespace EnergyApp.Commands.Categories
{
    public class GetCategoryByTitleQueryHandler : IRequestHandler<GetCategoryByTitleQuery, Category>
    {
        private readonly ICategoryRepository categoryRepository;

        public GetCategoryByTitleQueryHandler(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task<Category> Handle(GetCategoryByTitleQuery request, CancellationToken cancellationToken)
        {
            return await this.categoryRepository.FindByTitleAsync(request.Title);
        }
    }
}
