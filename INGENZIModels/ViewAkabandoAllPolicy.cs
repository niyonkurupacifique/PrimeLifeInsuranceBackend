using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewAkabandoAllPolicy
{
    public string CustomerCode { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string? PhoneNumber1 { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public string? ProductCategory { get; set; }

    public double RiskPremium { get; set; }

    public bool Claimed { get; set; }

    public bool Surrended { get; set; }

    public DateOnly? RecordedDate { get; set; }

    public string SchemeId { get; set; } = null!;
}
