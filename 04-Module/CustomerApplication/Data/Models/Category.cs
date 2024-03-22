namespace CustomerApplication.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static CustomerApplication.Commons.ValidationConstants.CategoryConstants;

    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(MaxCategoryNameLength)]
        public string Name { get; set; } = null!;

        public IEnumerable<Product> Products { get; set; }
    }
}
