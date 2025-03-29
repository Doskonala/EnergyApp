using EnergyApp.Models;
using EnergyApp.Repositories;
using MediatR;

namespace EnergyApp.Commands.Categories
{
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQuery, Category>
    {
        private readonly ICategoryRepository categoryRepository;

        public GetCategoryQueryHandler(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task<Category> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {
            return await this.categoryRepository.FindAsync(request.Id);
        }
    }
}
