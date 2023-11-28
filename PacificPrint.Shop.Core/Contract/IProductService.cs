using PacificPrint.Shop.Core.Common;
using PacificPrint.Shop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PacificPrint.Shop.Core.Contract
{
    public interface IProductService : IEntityServiceBase<Product, Guid>
    {
    }
}
