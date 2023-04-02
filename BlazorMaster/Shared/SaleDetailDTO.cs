using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMaster.Shared
{
    public class SaleDetailDTO
    {
        public int? Amount { get; set; }

        public decimal? SubTotal { get; set; }

        public virtual ProductDTO? Product { get; set; }
    }
}
