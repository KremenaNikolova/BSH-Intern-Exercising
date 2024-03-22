namespace CustomerApplication.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static CustomerApplication.Commons.ValidationConstants.ProductConstants;

    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        [MaxLength(MaxProductNameLength)]
        public string Name { get; set; } = null!;

        [Required]
        public Category Category { get; set; } = null!;

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

    }
}
