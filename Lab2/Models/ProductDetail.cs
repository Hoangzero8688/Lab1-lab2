using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Lab2.Models
{
    public class ProductDetail
    {
        public int Id { get; set; }

       
        [Display(Name = "Image URL")]
        //[RegularExpression(@"\.(jpg|jpeg|png|gif)$", ErrorMessage = "Please enter a valid image URL")]
        public string? ImageUrl { get; set; }

        // Foreign keys
        [Required(ErrorMessage = "Product ID is required")]
        [Display(Name = "Product ID")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Size ID is required")]
        [Display(Name = "Size ID")]
        public int SizeId { get; set; }

        [Required(ErrorMessage = "Color ID is required")]
        [Display(Name = "Color ID")]
        public int ColorId { get; set; }

        // Navigation properties
        public Product Product { get; set; }

        public Size Size { get; set; }

        public Color Color { get; set; }



    }
}
