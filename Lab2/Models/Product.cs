using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

       
        [Display(Name = "Product Description")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Product price is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a valid price")]
        [Display(Name = "Product Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Product quantity is required")]
        [Display(Name = "Product Quantity")]
        public int Quantity { get; set; }

        // Navigation property
        public List<ProductDetail> Details { get; set; }

    }
}
