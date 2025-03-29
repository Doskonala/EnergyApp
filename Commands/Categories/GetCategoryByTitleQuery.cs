using EnergyApp.Models;
using MediatR;

namespace EnergyApp.Commands.Categories
{
    public class GetCategoryByTitleQuery : IRequest<Category>
    {
        public string Title { get; set; }
    }
}
