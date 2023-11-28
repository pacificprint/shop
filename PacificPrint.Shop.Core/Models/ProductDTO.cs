using System;
using System.Collections.Generic;

namespace PacificPrint.Shop.Core.Models
{
    public class ProductDTO
    {
        public Guid Id {get; set;}
        public string Name {get; set;}
        public string? Description {get; set;}
        public int Category {get; set;}
        public decimal UnitValue {get; set;}
        public DateTime CreatedAt {get; set;}
        public DateTime UpdatedAt {get; set;}
    }
}
