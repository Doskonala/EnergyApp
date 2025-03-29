using SolarApi.Models;

namespace EnergyApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<SolarPanel> Panels { get; set; }
    }
}