using EnergyApp.Models;
using MediatR;

namespace EnergyApp.Commands.Categories
{
    public class GetCategoryQuery : IRequest<Category>
    {
        public int Id { get; set; }
    }
}
