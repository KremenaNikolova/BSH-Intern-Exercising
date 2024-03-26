using Lab5.Optional.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Lab5.Optional.Models
{
    public class Clothing : IProduct
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Size { get; set; }
    }
}
