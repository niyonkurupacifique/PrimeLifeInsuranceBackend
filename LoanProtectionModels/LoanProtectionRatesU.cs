using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class LoanProtectionRatesU
{
    public int IdRecord { get; set; }

    public int? Age { get; set; }

    public double? Duration { get; set; }

    public string? BorrowerType { get; set; }

    public double? Rate { get; set; }

    public string? RateType { get; set; }

    public double? Fees { get; set; }
}
