using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EnergyApp.Commands.Panels;
using EnergyApp.ViewModels.Panel;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SolarApi.Models;

namespace EnergyApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolarPanelsController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;

        public SolarPanelsController(IMediator mediator, IMapper mapper)
        {
            this.mediator = mediator;
            this.mapper = mapper;
        }

        [HttpGet("list")]
        [Authorize]
        public async Task<IActionResult> Get()
        {
            var panels = await mediator.Send(new GetAllPanelsQuery());

            var panelListViewModels = mapper.Map<List<PanelListViewModel>>(panels);

            return Ok(panelListViewModels);
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var panel = await this.mediator.Send(new GetPanelQuery { Id = id });
            if (panel == null)
            {
                return NotFound();
            }

            return Ok(panel);
        }

        [HttpGet("byName")]
        public async Task<IActionResult> GetByName(string name)
        {
            var panel = await this.mediator.Send(new GetPanelByNameQuery { Name = name });
            if (panel == null)
            {
                return NotFound();
            }

            return Ok(panel);
        }

        [HttpPost]
        public async Task<IActionResult> Post(SolarPanel panel)
        {
            var createPanelCommand = new CreatePanelCommand
            {
                Name = panel.Name
            };

            await mediator.Send(createPanelCommand);

            return Ok(panel);
        }

        [HttpPut]
        public async Task<IActionResult> Put(SolarPanel panel)
        {
            var updatePanelCommand = new UpdatePanelCommand
            {
                Id = (int)panel.Id,
                Name = panel.Name
            };

            await mediator.Send(updatePanelCommand);

            return Ok(panel);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await mediator.Send(new DeletePanelCommand { Id = id });

            return NoContent();
        }
    }
}
