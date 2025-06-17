using System;
using System.Collections.Generic;

namespace DataLayer.Models;

public partial class TblInvoice
{
    public int Id { get; set; }

    public string? Serial { get; set; }

    public int? InvoiceNo { get; set; }

    public short? CustomerId { get; set; }

    public DateOnly? IssueDate { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public string? TaxOffice { get; set; }

    public string? TaxNumber { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? Discount { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? NetTotal { get; set; }

    public string? Note { get; set; }
}
