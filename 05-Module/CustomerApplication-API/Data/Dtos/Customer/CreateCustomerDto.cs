namespace CustomerApplication_API.Data.Dtos.Customer
{
    using System.ComponentModel.DataAnnotations;

    using CustomerApplication_API.Data.Dtos.Customer.Enum;
    
    using static CustomerApplication_API.Commons.ValidationConstants.CustomerConstants;
    using static CustomerApplication_API.Commons.ErrorMessages;

    public class CreateCustomerDto
    {
        [Required]
        [Display(Name = "First Name")]
        [StringLength(MaxFirstNameLength, ErrorMessage = WrongFirstNameInput, MinimumLength = MinFirstNameLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(MaxLastNameLength, ErrorMessage = WrongLastNameInput, MinimumLength = MinLastNameLength)]
        public string LastName { get; set; } = null!;

        [Required]
        [RegularExpression(EmailValidation, ErrorMessage = WrongEmailInput)]
        public string Email { get; set; } = null!;

        [Display(Name = "Phone Number")]
        [RegularExpression(PhoneNumberValidation, ErrorMessage = WrongPhoneNumberInput)]
        public string? PhoneNumber { get; set; }

        public Gender? Gender { get; set; }

        public string? Country { get; set; }

        public string? City { get; set; }

        public DateTime? Birthday { get; set; }
    }
}
