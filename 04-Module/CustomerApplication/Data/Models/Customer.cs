namespace CustomerApplication.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static CustomerApplication.Commons.ValidationConstants.CustomerConstants;

    public class Customer
    {
        public Customer()
        {
            CustomerProducts = new List<CustomerProduct>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxFirstNameLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(MaxLastNameLength)]
        public string LastName { get; set; } = null!;

        [Required]
        [MaxLength(EmailMaxLength)]
        public string Email { get; set; } = null!;

        [Display(Name = "Phone Number")]
        [RegularExpression(PhoneNumberValidation)]
        public string? PhoneNumber { get; set; }

        public string? Gender { get; set; }

        public string? Country { get; set; }

        public string? City { get; set; }

        public DateTime? Birthday { get; set; }

        public IEnumerable<CustomerProduct> CustomerProducts { get; set; }
    }
}
