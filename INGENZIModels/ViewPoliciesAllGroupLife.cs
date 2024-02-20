using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewPoliciesAllGroupLife
{
    public string CustomerCode { get; set; } = null!;

    public string SchemePolicy { get; set; } = null!;

    public string? SchemeName { get; set; }

    public string PolicyNumberChild { get; set; } = null!;

    public string? FullName { get; set; }

    public double? TotalPremium { get; set; }

    public string Product { get; set; } = null!;

    public string PolicyStatus { get; set; } = null!;

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public string? ChannelName { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public string MaturityStatus { get; set; } = null!;

    public string? PhoneNumber1 { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public DateTime? EndDateOfEndowmentPayment { get; set; }

    public int? PolicyTermYears { get; set; }

    public double? PremiumPayingTermInYear { get; set; }

    public int EndowmentNumberInYear { get; set; }

    public int EndowmentAmountDuringDeferredPeriod { get; set; }

    public int EndowmentAmountAfterDeferredPeriod { get; set; }

    public string? PremiumFrequency { get; set; }

    public int EndorsementMade { get; set; }

    public string Expr1ProductCategory { get; set; } = null!;

    public string? IdDocumentNumber { get; set; }
}
