using System.ComponentModel.DataAnnotations;

namespace EnergyApp.ViewModels.Panel
{
    public class CreatePanelViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

        [Required]
        public int CategoryId { get; set; }
    }
}
