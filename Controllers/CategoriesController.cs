using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EnergyApp.Models;
using SolarApi.Models;
using AutoMapper;
using EnergyApp.Commands.Categories;
using EnergyApp.ViewModels.Category;
using MediatR;

namespace EnergyApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;

        public CategoriesController(IMediator mediator, IMapper mapper)
        {
            this.mediator = mediator;
            this.mapper = mapper;
        }

        [HttpGet("list")]
        public async Task<IActionResult> Get()
        {
            var categories = await mediator.Send(new GetAllCategoriesQuery());

            var categoryListViewModels = mapper.Map<List<CategoryListViewModel>>(categories);

            return Ok(categoryListViewModels);
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await this.mediator.Send(new GetCategoryQuery { Id = id });
            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        [HttpGet("byTitle")]
        public async Task<IActionResult> GetByTitle(string title)
        {
            var category = await this.mediator.Send(new GetCategoryByTitleQuery { Title = title });
            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Category category)
        {
            var createCategoryCommand = new CreateCategoryCommand
            {
                Title = category.Title
            };

            await mediator.Send(createCategoryCommand);

            return Ok(category);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Category category)
        {
            var updateCategoryCommand = new UpdateCategoryCommand
            {
                Id = category.Id,
                Title = category.Title
            };

            await mediator.Send(updateCategoryCommand);

            return Ok(category);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await mediator.Send(new DeleteCategoryCommand { Id = id });

            return NoContent();
        }
    }
}
