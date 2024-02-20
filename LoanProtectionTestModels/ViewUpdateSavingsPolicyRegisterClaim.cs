using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewUpdateSavingsPolicyRegisterClaim
{
    public int IdRecord { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string? IdDocumentNumber { get; set; }

    public string? PhoneNumber { get; set; }

    public string PolicyNumberChild { get; set; } = null!;

    public bool Endors { get; set; }

    public string PolicyStaus { get; set; } = null!;

    public string? EffectiveDate { get; set; }

    public string? MaturityDate { get; set; }

    public bool Cancelled { get; set; }

    public bool Surrendered { get; set; }

    public bool Suspended { get; set; }
}
