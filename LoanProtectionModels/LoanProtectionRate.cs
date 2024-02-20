using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class LoanProtectionRate
{
    public int IdRecord { get; set; }

    public double? Age { get; set; }

    public double? LoanPeriod { get; set; }

    public double? InsuranceRate { get; set; }

    public string? TypeRate { get; set; }
}
