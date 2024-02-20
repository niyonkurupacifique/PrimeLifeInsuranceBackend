using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class LoanProtectionRatesEquity
{
    public int IdRecord { get; set; }

    public int Age { get; set; }

    public int Duration { get; set; }

    public string LoanType { get; set; } = null!;

    public string PaymentRateType { get; set; } = null!;

    public string BorrowerType { get; set; } = null!;

    public double BaseRate { get; set; }

    public double RetrenchmentRate { get; set; }

    public double JointlifeRate { get; set; }

    public double Fees { get; set; }
}
