namespace CustomerApplication_API.Commons
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

            public const string EmailAlreadyExist = "User with this email already exist";

            public const string PhoneNumberValidation = "[0-9]{3}-[0-9]{3}-[0-9]{4}";

            public const string EmailValidation = "^((?!\\.)[\\w-_.]*[^.])(@\\w+)(\\.\\w+(\\.\\w+)?[^.\\W])$";
        }

        public static class CategoryConstants
        {
            public const int MaxCategoryNameLength = 50;
        }

        public static class ProductConstants
        {
            public const int MinProductNameLength = 2;
            public const int MaxProductNameLength = 100;

            public const string MinPriceValue = "0";
            public const string MaxPriceValue = "1000";
        }

        public static class PageValidation
        {
            public const int pageSize = 12;
        }
    }
}
