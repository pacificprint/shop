using System.Collections.Generic;
using System.Linq;

namespace PacificPrint.Shop.Core.Common
{
    public class PagedResult<TModel>
    {
        public int Total { get; set; }

        public IEnumerable<TModel> Data { get; set; } = Enumerable.Empty<TModel>();
    }
}
