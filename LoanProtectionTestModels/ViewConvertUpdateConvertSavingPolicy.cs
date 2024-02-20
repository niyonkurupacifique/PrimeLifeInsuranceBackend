using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewConvertUpdateConvertSavingPolicy
{
    public string PolicyNumber { get; set; } = null!;

    public DateTime PolicyDate { get; set; }

    public int Term { get; set; }

    public double Contribution { get; set; }

    public string PaymentMode { get; set; } = null!;

    public double SumAssured { get; set; }
}
