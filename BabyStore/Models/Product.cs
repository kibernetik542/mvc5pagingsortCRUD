using System.ComponentModel.DataAnnotations;

namespace BabyStore.Models
{
    public partial class Product
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "The product name cannot be blank")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter a product name between 3 and 50 characters in length")]
        [RegularExpression(@"^[a-zA-Z0-9'-'\s]*$", ErrorMessage = "Please enter a product name made up of letters and numbers only")]
        [Display(Name = "Product Name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "The product description cannot be blank")]
        [StringLength(300, MinimumLength = 10, ErrorMessage = "Please enter a product description between 10 and 300 characters in length")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "The price cannot be blank")]
        [Range(0.10, 30000, ErrorMessage = "Please enter a price between 0.10 and 30000.00")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }


        public int? CategoryID { get; set; }


        public virtual Category Category { get; set; }
    }
}