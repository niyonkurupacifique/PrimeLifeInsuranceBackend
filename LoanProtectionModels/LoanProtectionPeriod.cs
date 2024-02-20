using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class LoanProtectionPeriod
{
    public int IdRecord { get; set; }

    public int Year { get; set; }

    public int Month { get; set; }

    public bool Locked { get; set; }

    public string UnikValue { get; set; } = null!;
}
