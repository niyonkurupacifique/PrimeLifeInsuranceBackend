using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class SavingsChannel
{
    public string VendorCode { get; set; } = null!;

    public string? VendorName { get; set; }

    public string? VendorType { get; set; }

    public bool? Active { get; set; }

    public double? CommissionRate { get; set; }
}
