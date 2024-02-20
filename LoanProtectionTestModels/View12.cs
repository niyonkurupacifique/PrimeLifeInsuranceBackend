using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class View12
{
    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public bool Surrendered { get; set; }

    public bool Cancelled { get; set; }

    public string SchemeId { get; set; } = null!;
}
