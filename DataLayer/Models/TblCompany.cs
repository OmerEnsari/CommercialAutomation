using System;
using System.Collections.Generic;

namespace DataLayer.Models;

public partial class TblCompany
{
    public short Id { get; set; }

    public string? Name { get; set; }

    public string? AuthorizedStatus { get; set; }

    public string? AuthorizedNameSurname { get; set; }

    public string? TelNo1 { get; set; }

    public string? TelNo2 { get; set; }

    public string? TelNo3 { get; set; }

    public string? Mail { get; set; }

    public string? Fax { get; set; }

    public string? Province { get; set; }

    public string? District { get; set; }

    public string? Address { get; set; }

    public string? TaxOffice { get; set; }
}
