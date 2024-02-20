using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class LoanProtectionRatesBkx
{
    public int IdRecord { get; set; }

    public int? Age { get; set; }

    public double? Duration { get; set; }

    public string? LoanType { get; set; }

    public string? PaymentRateType { get; set; }

    public string? BorrowerType { get; set; }

    public double? BaseRate { get; set; }

    public double? RetrenchmentRate { get; set; }

    public double? JointlifeRate { get; set; }

    public double? Fees { get; set; }
}
