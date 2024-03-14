namespace CustomerApplication.Data.Model
{
    using System.ComponentModel.DataAnnotations;

    using static CustomerApplication.Commons.ValidationConstants.CustomerConstants;

    public class Customer
    {
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

        public string Gender { get; set; } = null!;

        public string Country { get; set; } = null!;

        public string City { get; set; } = null!;

        public DateTime Birthday { get; set; }
    }
}
