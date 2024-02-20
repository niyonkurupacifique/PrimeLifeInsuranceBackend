using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewSms5Family
{
    public string FullName { get; set; } = null!;

    public string? PhoneNumber1 { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public string? PremiumFrequency { get; set; }

    public double? Premiums { get; set; }

    public string? PaymentMode { get; set; }

    public DateTime PaymentPeriod { get; set; }

    public bool Claimed { get; set; }

    public bool Surrended { get; set; }
}
