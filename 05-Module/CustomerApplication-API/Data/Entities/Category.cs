namespace CustomerApplication_API.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    using static CustomerApplication_API.Commons.ValidationConstants.CategoryConstants;

    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxCategoryNameLength)]
        public string Name { get; set; } = null!;

        public IEnumerable<Product> Products { get; set; }
    }
}
