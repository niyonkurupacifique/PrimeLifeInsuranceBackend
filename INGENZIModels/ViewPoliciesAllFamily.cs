using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewPoliciesAllFamily
{
    public string? CustomerCode { get; set; }

    public string? IdDocument { get; set; }

    public string Names { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public double RiskPremium { get; set; }

    public string Product { get; set; } = null!;

    public string PolicyStatus { get; set; } = null!;

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public string SchemeId { get; set; } = null!;

    public string? SchemeName { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? EndDateOfPremiumPayment { get; set; }

    public string MaturityStatus { get; set; } = null!;

    public string? PhoneNumber1 { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public DateTime? EndDateOfEndowmentPayment { get; set; }

    public int PolicyTermInYear { get; set; }

    public double PremiumPayingTermInYear { get; set; }

    public int EndowmentNumberInYear { get; set; }

    public int EndowmentAmountDuringDeferredPeriod { get; set; }

    public int EndowmentAmountAfterDeferredPeriod { get; set; }

    public string? PremiumFrequency { get; set; }

    public string PolicyNumberMain { get; set; } = null!;

    public int EndorsementMade { get; set; }

    public string? ProductCategory { get; set; }
}
