using System;
using System.Collections.Generic;

namespace PacificPrint.Shop.Data.Entities;

public partial class OrderDetail
{
    public Guid Id { get; set; }

    public Guid OrderId { get; set; }

    public Guid ProductId { get; set; }

    public int Quantity { get; set; }

    public decimal UnitValue { get; set; }

    public decimal TotalValue { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
