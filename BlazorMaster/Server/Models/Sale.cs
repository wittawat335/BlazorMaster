using System;
using System.Collections.Generic;

namespace BlazorMaster.Server.Models;

public partial class Sale
{
    public int SaleId { get; set; }

    public string? Customer { get; set; }

    public decimal? Total { get; set; }

    public virtual ICollection<SaleDetail> SaleDetails { get; set; } = new List<SaleDetail>();
}
