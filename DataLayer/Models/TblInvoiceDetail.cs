using System;
using System.Collections.Generic;

namespace DataLayer.Models;

public partial class TblInvoiceDetail
{
    public int Id { get; set; }

    public int? InvoiceId { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public string? Unit { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? Vat { get; set; }

    public decimal? Total { get; set; }
}
