namespace CustomerApplication.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class CustomerProduct
    {
        [Required]
        public Customer Customer { get; set; } = null!;

        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }

        [Required]
        public Product Product { get; set; } = null!;

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        public int Quantity { get; set; }

    }
}
