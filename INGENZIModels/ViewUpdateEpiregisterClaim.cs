using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewUpdateEpiregisterClaim
{
    public int IdRecord { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string? IdDocumentNumber { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string FullName { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public DateOnly? CreationDate { get; set; }

    public DateOnly? RecordedDate { get; set; }

    public string? PolicyStatus { get; set; }

    public bool? Cancelled { get; set; }

    public bool? Claimed { get; set; }

    public double RiskPremium { get; set; }
}
