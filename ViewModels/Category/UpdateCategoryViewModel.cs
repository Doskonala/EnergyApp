using System.ComponentModel.DataAnnotations;

namespace EnergyApp.ViewModels.Category
{
    public class UpdateCategoryViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
    }
}
