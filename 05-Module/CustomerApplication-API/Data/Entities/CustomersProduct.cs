using System;
using System.Collections.Generic;

namespace CustomerApplication_API.Data.Entities;

public partial class CustomersProduct
{
    public int CustomerId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
