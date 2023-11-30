using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class Color
    {
        public int ColorId { get; set; }

        [Required(ErrorMessage = "Color name is required")]
        [Display(Name = "Color Name")]
        public string Name { get; set; }
    }
}
