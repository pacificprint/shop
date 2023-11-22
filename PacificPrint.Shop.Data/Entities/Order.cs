using System;
using System.Collections.Generic;

namespace PacificPrint.Shop.Data.Entities;

public partial class Order
{
    public Guid Id { get; set; }

    public Guid ClientId { get; set; }

    public Guid UserId { get; set; }

    public int Status { get; set; }

    public int Payment { get; set; }

    public decimal PaymentValue { get; set; }

    public decimal TotalValue { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual Client Client { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual User User { get; set; } = null!;
}
