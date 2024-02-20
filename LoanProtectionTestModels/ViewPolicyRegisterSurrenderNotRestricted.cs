using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewPolicyRegisterSurrenderNotRestricted
{
    public string PolicyNumberChild { get; set; } = null!;

    public bool EndorsementMade { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string? PhoneNumber { get; set; }
}
