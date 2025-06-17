using System;
using System.Collections.Generic;

namespace DataLayer.Models;

public partial class TblProvince
{
    public int Id { get; set; }

    public string ProvinceName { get; set; } = null!;

    public virtual ICollection<TblDistrict> TblDistricts { get; set; } = new List<TblDistrict>();
}
