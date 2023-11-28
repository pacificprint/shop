using System;
using System.Collections.Generic;

namespace PacificPrint.Shop.Core.Models
{
    public class OrderDetailDTO
    {
        public Guid Id {get; set;}
        public Guid OrderId {get; set;}
        public Guid ProductId {get; set;}
        public int Quantity {get; set;}
        public decimal UnitValue {get; set;}
        public decimal TotalValue {get; set;}
        public DateTime CreatedAt {get; set;}
        public DateTime UpdatedAt {get; set;}
    }
}
