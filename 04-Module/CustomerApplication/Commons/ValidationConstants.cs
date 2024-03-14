namespace CustomerApplication.Commons
{
    public static class ValidationConstants
    {
        public static class CustomerConstants
        {
            public const int MinFirstNameLength = 2;

            public const int MaxFirstNameLength = 50;

            public const int MinLastNameLength = 2;

            public const int MaxLastNameLength = 50;

            public const int EmailMaxLength = 70;

            public const string PhoneNumberValidation = "[0-9]{3}-[0-9]{3}-[0-9]{4}";
        }
    }
}
