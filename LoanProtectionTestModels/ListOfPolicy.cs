using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ListOfPolicy
{
    public int Position { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string EndorsementMade { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string? CustomerCode { get; set; }
}
