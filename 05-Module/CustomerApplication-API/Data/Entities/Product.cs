using System;
using System.Collections.Generic;

namespace CustomerApplication_API.Data.Entities;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int CategoryId { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<CustomersProduct> CustomersProducts { get; set; } = new List<CustomersProduct>();
}
