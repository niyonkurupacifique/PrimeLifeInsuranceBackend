using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class View15
{
    public string SchemeId { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public bool Cancelled { get; set; }

    public bool Surrendered { get; set; }

    public string PolicyNumberChild { get; set; } = null!;
}
