using System;
using System.Collections.Generic;

namespace DataLayer.Models;

public partial class TblExpense
{
    public int Id { get; set; }

    public string? Month { get; set; }

    public int? Year { get; set; }

    public decimal? Electricity { get; set; }

    public decimal? Water { get; set; }

    public decimal? NaturalGas { get; set; }

    public decimal? Internet { get; set; }

    public decimal? Salaries { get; set; }

    public decimal? Other { get; set; }

    public string? Description { get; set; }

    public string? CreatedBy { get; set; }
}
