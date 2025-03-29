using EnergyApp.Models;
using EnergyApp.Repositories;
using MediatR;
namespace EnergyApp.Commands.Categories
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand>
    {
        private readonly ICategoryRepository categoryRepository;

        public CreateCategoryCommandHandler(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = new Category
            {
                Title = request.Title
            };

            await categoryRepository.AddAsync(category);
        }
    }
}
