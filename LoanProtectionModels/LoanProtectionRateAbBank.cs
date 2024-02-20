using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class LoanProtectionRateAbBank
{
    public int IdRecord { get; set; }

    public string IdBank { get; set; } = null!;

    public string LoanType { get; set; } = null!;

    public int Range { get; set; }

    public double Rate { get; set; }

    public int Fees { get; set; }

    public string? BorrowerType { get; set; }
}
