using System;
using System.Collections.Generic;

namespace DataLayer.Models;

public partial class TblCustomer
{
    public short Id { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? TelNo { get; set; }

    public string? TelNo2 { get; set; }

    public string? Tcno { get; set; }

    public string? Mail { get; set; }

    public string? Province { get; set; }

    public string? District { get; set; }

    public string? Address { get; set; }

    public string? TaxOffice { get; set; }
}
