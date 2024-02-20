using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class LoanProtectionRateVision
{
    public int? Age { get; set; }

    public int? LoanPeriod { get; set; }

    public double? InsuranceRate { get; set; }

    public string? TypeRate { get; set; }
}
