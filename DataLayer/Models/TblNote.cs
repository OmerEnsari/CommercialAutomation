using System;
using System.Collections.Generic;

namespace DataLayer.Models;

public partial class TblNote
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public TimeOnly? Time { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Creator { get; set; }
}
