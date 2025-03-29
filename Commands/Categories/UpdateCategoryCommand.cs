﻿using MediatR;

namespace EnergyApp.Commands.Categories
{
    public class UpdateCategoryCommand : IRequest
    {
        public int Id { get; set; }

        public string Title { get; set; }
    }
}
