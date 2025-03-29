using System.ComponentModel.DataAnnotations;

namespace EnergyApp.ViewModels.Panel
{
    public class UpdatePanelViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

        [Required]
        public int CategoryId { get; set; }
    }
}
