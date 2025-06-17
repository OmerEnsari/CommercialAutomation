using System;
using System.Collections.Generic;

namespace DataLayer.Models;

public partial class TblStock
{
    public short Id { get; set; }

    public string? StockType { get; set; }

    public short? StockQuantity { get; set; }
}
