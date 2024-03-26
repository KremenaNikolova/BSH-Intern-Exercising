using System.ComponentModel.DataAnnotations;
using Lab5.Optional.Helpers;
using Lab5.Optional.Models.Interfaces;

namespace Lab5.Optional.Models
{
    public class Food : IProduct
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [CustomPriority(2)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [CustomPriority(1, isDescending: true)]
        public DateTime ExpirationDate { get; set; }
    }
}
