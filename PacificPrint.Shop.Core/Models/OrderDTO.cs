using System;
using System.Collections.Generic;

namespace PacificPrint.Shop.Core.Models
{
    public class OrderDTO
    {
        public Guid Id {get; set;}
        public Guid ClientId {get; set;}
        public Guid UserId {get; set;}
        public int Status {get; set;}
        public int Payment {get; set;}
        public decimal PaymentValue {get; set;}
        public decimal TotalValue {get; set;}
        public DateTime CreatedAt {get; set;}
        public DateTime UpdatedAt {get; set;}
    }
}
