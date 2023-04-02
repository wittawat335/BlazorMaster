using System;
using System.Collections.Generic;

namespace BlazorMaster.Server.Models;

public partial class SaleDetail
{
    public int SaleDetailId { get; set; }

    public int? SaleId { get; set; }

    public int? ProductId { get; set; }

    public int? Amount { get; set; }

    public decimal? SubTotal { get; set; }

    public virtual Product? Product { get; set; }

    public virtual Sale? Sale { get; set; }
}
