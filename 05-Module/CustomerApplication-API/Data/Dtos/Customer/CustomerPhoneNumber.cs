namespace CustomerApplication_API.Data.Dtos.Customer
{
    using System.ComponentModel.DataAnnotations;

    using static CustomerApplication_API.Commons.ValidationConstants.CustomerConstants;
    using static CustomerApplication_API.Commons.ErrorMessages;

    public class CustomerPhoneNumber
    {
        public int Id { get; set; }

        [Display(Name = "Phone Number")]
        [RegularExpression(PhoneNumberValidation, ErrorMessage = WrongPhoneNumberInput)]
        public string? PhoneNumber { get; set; }
    }
}
