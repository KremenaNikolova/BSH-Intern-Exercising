namespace CustomerApplication.ViewModels.Product
{
    using System.ComponentModel.DataAnnotations;

    public class CustomerProducts
    {
        public int CustomerId { get; set; }

        public int ProductId { get; set; }

        [Display(Name = "Customer Name")]
        public string FullName { get; set; } = null!;

        public string Product { get; set; } = null!;

        public int Quantity { get; set; }


    }
}
