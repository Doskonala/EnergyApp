using EnergyApp.Models;
using EnergyApp.Repositories;
using MediatR;

namespace EnergyApp.Commands.Categories
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand>
    {
        private readonly ICategoryRepository categoryRepository;

        public UpdateCategoryCommandHandler(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = new Category
            {
                Id = request.Id,
                Title = request.Title
            };

            await categoryRepository.UpdateAsync(category);
        }
    }
}
