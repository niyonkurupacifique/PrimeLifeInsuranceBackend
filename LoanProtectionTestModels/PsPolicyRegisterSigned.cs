using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class PsPolicyRegisterSigned
{
    public int IdRecord { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public bool? Signed { get; set; }

    public DateTime? SignedDate { get; set; }
}
