using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class Size
    {
        public int SizeId { get; set; }

        [Required(ErrorMessage = "Size name is required")]
        [Display(Name = "Size Name")]
        public string Name { get; set; }
    }
}
