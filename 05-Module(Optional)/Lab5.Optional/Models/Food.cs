using System.ComponentModel.DataAnnotations;
using Lab5.Optional.Models.Interfaces;

namespace Lab5.Optional.Models
{
    public class Food : IProduct
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public DateTime ExpirationDate { get; set; }
    }
}
