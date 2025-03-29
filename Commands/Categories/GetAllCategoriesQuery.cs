using EnergyApp.Models;
using MediatR;

namespace EnergyApp.Commands.Categories
{
    public class GetAllCategoriesQuery : IRequest<List<Category>>
    {
    }
}
