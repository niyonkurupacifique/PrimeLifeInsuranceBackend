using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewTableOfPayementPlan
{
    public int Period { get; set; }

    public string? SchemeNumber { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public double Contribution { get; set; }

    public double CommissionAmount { get; set; }

    public double PensionAmount { get; set; }

    public double InvestedPremium { get; set; }

    public double AcquiredValue { get; set; }

    public DateOnly? PayementDueDate { get; set; }

    public DateTime EndDate { get; set; }
}
