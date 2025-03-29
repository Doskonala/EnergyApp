using EnergyApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SolarApi.Models;

public class SolarContext : DbContext
{
    public SolarContext(DbContextOptions<SolarContext> options)
    : base(options)
    {
    }

    public DbSet<SolarPanel> SolarPanels { get; set; } = null!;
    public DbSet<SolarPanel> Categories { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
            .HasMany(category => category.Panels)
            .WithOne(solarPanel => solarPanel.Category)
            .HasForeignKey(solarPanel => solarPanel.CategoryId);
    }
}