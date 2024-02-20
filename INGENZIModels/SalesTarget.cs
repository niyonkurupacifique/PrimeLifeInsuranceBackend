using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class SalesTarget
{
    public int IdRecord { get; set; }

    public string ProductType { get; set; } = null!;

    public int Years { get; set; }

    public int Months { get; set; }

    public string ReportingMonths { get; set; } = null!;

    public double? TargetedAmounts { get; set; }
}
