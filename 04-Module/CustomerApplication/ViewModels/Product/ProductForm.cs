namespace CustomerApplication.ViewModels.Product
{
    using CustomerApplication.Data.Models;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    using static CustomerApplication.Commons.ValidationConstants.ProductConstants;
    using static CustomerApplication.Commons.ErrorMessages;

    public class ProductForm
    {
        [Display(Name = "Product Name")]
        [StringLength(MaxProductNameLength, MinimumLength = MinProductNameLength, ErrorMessage = InvalidProductName)]
        public string Name { get; set; } = null!;

        public string Category { get; set; } = null!;

        [Range(typeof(decimal), MinPriceValue, MaxPriceValue, ErrorMessage = InvalidPrice)]
        public decimal Price { get; set; }

        public int Quantity { get; set; }

    }
}
