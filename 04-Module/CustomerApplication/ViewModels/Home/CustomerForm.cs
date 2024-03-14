﻿namespace CustomerApplication.ViewModels.Home
{
    using System.ComponentModel.DataAnnotations;

    using CustomerApplication.ViewModels.Home.Enums;
    
    using static CustomerApplication.Commons.ValidationConstants.CustomerConstants;
    using static CustomerApplication.Commons.ErrorMessages;

    public class CustomerForm
    {
        [Key]
        public int Id { get; set; }

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
