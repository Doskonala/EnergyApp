using EnergyApp.Commands.Categories;
using EnergyApp.Mapping;
using EnergyApp.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using SolarApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<SolarContext>(opt =>
    opt.UseInMemoryDatabase("SolarPanels"));

builder.Services.AddAutoMapper(typeof(CategoryProfile).Assembly);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IPanelRepository, PanelRepository>();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<CreateCategoryCommandHandler>());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
