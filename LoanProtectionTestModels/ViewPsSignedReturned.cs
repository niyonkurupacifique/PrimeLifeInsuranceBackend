using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewPsSignedReturned
{
    public string PolicyNumberChild { get; set; } = null!;

    public DateTime RecordDate { get; set; }

    public DateTime StartDate { get; set; }

    public bool? Signed { get; set; }

    public DateTime? SignedDate { get; set; }

    public string PolicyStatus { get; set; } = null!;

    public string PolicyType { get; set; } = null!;
}
