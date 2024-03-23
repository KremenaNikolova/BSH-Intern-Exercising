using System;
using System.Collections.Generic;

namespace CustomerApplication_API.Data.Entities;

public partial class Customer
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string? Gender { get; set; }

    public string? Country { get; set; }

    public string? City { get; set; }

    public DateTime? Birthday { get; set; }

    public virtual ICollection<CustomersProduct> CustomersProducts { get; set; } = new List<CustomersProduct>();
}
