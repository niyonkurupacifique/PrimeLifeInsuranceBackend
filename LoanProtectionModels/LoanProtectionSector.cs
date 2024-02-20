using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class LoanProtectionSector
{
    public int IdRecord { get; set; }

    public string SectorId { get; set; } = null!;

    public string SectorName { get; set; } = null!;

    public string DistrictId { get; set; } = null!;
}
