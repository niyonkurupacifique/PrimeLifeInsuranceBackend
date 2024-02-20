using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewExpoPensionDetailsTable
{
    public int IdRecord { get; set; }

    public string? IdentityRecord { get; set; }

    public int? Period { get; set; }

    public string SchemeNumber { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public double Contribution { get; set; }

    public string ManagementFees { get; set; } = null!;

    public string InstallmentFees { get; set; } = null!;

    public double Rate { get; set; }

    public string Commission { get; set; } = null!;

    public string PensionAmt { get; set; } = null!;

    public double InvestedPremium { get; set; }

    public double AcquiredValue { get; set; }

    public DateTime DueDate { get; set; }
}
