using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class LoanProtectionDistrict
{
    public int IdRecord { get; set; }

    public string DistrictId { get; set; } = null!;

    public string DistrictName { get; set; } = null!;

    public string ProvinceId { get; set; } = null!;
}
