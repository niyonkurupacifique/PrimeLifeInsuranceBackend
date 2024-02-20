using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class LoanProtectionEquityRate
{
    public int IdRecord { get; set; }

    public int Duration { get; set; }

    public string LoanType { get; set; } = null!;

    public string BorrowerType { get; set; } = null!;

    public string CoversCategory { get; set; } = null!;

    public double Rate { get; set; }

    public string RateType { get; set; } = null!;

    public double? Fees { get; set; }
}
