using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMaster.Shared
{
    public class SaleDTO
    {
        public string? Customer { get; set; }

        public decimal? Total { get; set; }
        public virtual ICollection<SaleDetailDTO>? saleDetails { get; set; }
    }
}
