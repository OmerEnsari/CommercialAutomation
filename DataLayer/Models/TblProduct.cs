using System;
using System.Collections.Generic;

namespace DataLayer.Models;

public partial class TblProduct
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Brand { get; set; }

    public string? Model { get; set; }

    public string? Year { get; set; }

    public int? Quantity { get; set; }

    public decimal? CostPrice { get; set; }

    public decimal? SalePrice { get; set; }

    public string? Detail { get; set; }
}
