using System;
using System.Collections.Generic;

namespace DataLayer.Models;

public partial class TblDistrict
{
    public int Id { get; set; }

    public string DistrictName { get; set; } = null!;

    public int ProvinceId { get; set; }

    public virtual TblProvince Province { get; set; } = null!;
}
