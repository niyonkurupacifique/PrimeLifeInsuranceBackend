using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class TempSavingsProvision
{
    public int IdRecord { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public DateTime? ReportingDate { get; set; }

    public double? AmountProvisions { get; set; }

    public string? UserId { get; set; }

    public string? ProductTypes { get; set; }
}
