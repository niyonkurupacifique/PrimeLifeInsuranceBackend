using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewPsPolicyWithoutBeneficiary
{
    public string PolicyNumberChild { get; set; } = null!;

    public DateTime RecordDate { get; set; }

    public DateTime StartDate { get; set; }

    public string PolicyType { get; set; } = null!;

    public string PolicyStatus { get; set; } = null!;
}
