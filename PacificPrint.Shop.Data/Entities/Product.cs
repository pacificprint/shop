using System;
using System.Collections.Generic;

namespace PacificPrint.Shop.Data.Entities;

public partial class Product
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int Category { get; set; }

    public decimal UnitValue { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
