using EnergyApp.Models;

namespace SolarApi.Models;

public class SolarPanel
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public bool IsAvailable { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}
