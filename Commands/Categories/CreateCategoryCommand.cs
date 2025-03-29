using MediatR;
namespace EnergyApp.Commands.Categories
{
    public class CreateCategoryCommand : IRequest
    {
        public string Title { get; set; }
    }
}
