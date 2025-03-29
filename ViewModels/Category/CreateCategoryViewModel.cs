using System.ComponentModel.DataAnnotations;

namespace EnergyApp.ViewModels.Category
{
    public class CreateCategoryViewModel
    {
        [Required]
        public string Title { get; set; }
    }
}
