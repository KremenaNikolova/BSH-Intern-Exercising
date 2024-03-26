using Lab5.Optional.Helpers;
using Lab5.Optional.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Lab5.Optional.Models
{
    public class Clothing : IProduct
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [CustomPriority(2)]
        public string Name { get; set; }
        [Required]
        [CustomPriority(1, isDescending: true)]
        public decimal Price { get; set; }
        [Required]
        public string Size { get; set; }
    }
}
