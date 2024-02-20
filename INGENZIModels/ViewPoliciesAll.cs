using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewPoliciesAll
{
    public string? CustomerCode { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string FullName { get; set; } = null!;

    public string PolicyNumberEndo { get; set; } = null!;

    public double? Premium { get; set; }

    public string Product { get; set; } = null!;

    public string PolicyStatus { get; set; } = null!;

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public string? SchemeId { get; set; }

    public string? SchemeName { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDateOfPremiumPayment { get; set; }

    public string MaturityStatus { get; set; } = null!;

    public string? PhoneNumber1 { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public DateTime? EndDateOfEndowmentPayment { get; set; }

    public int? PolicyTermInYear { get; set; }

    public double PremiumPayingTermInYear { get; set; }

    public int? EndowmentNumberInYear { get; set; }

    public double? EndowmentAmountDuringDeferredPeriod { get; set; }

    public double? EndowmentAmountAfterDeferredPeriod { get; set; }

    public string? PremiumFrequency { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public int? EndorsementMade { get; set; }

    public string? ProductCategory { get; set; }
}
