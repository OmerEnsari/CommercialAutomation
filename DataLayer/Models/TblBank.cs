using System;
using System.Collections.Generic;

namespace DataLayer.Models;

public partial class TblBank
{
    public short Id { get; set; }

    public string? Name { get; set; }

    public string? Branch { get; set; }

    public string? Iban { get; set; }

    public string? AccountNo { get; set; }

    public string? Authorized { get; set; }

    public DateTime? Date { get; set; }

    public string? Type { get; set; }
}
