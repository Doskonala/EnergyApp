using MediatR;

namespace EnergyApp.Commands.Categories
{
    public class DeleteCategoryCommand : IRequest
    {
        public int Id { get; set; }
    }
}
