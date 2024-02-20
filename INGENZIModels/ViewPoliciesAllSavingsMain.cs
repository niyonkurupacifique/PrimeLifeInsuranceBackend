using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewPoliciesAllSavingsMain
{
    public string CustomerCode { get; set; } = null!;

    public string? IdDocumentNumber { get; set; }

    public string FullName { get; set; } = null!;

    public string PolicyNumberChild { get; set; } = null!;

    public double Contribution { get; set; }

    public string PolicyType { get; set; } = null!;

    public string PolicyStatus { get; set; } = null!;

    public string? PaymentChannel { get; set; }

    public string? Channel { get; set; }

    public string SchemeId { get; set; } = null!;

    public string SchemeName { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDateOfPremiumPayment { get; set; }

    public string MaturityStatus { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public DateTime EndDateOfEndowmentPayment { get; set; }

    public int PolicyTermInYear { get; set; }

    public double PremiumPayingTermInYear { get; set; }

    public int EndowmentNumberInYear { get; set; }

    public int EndowmentAmountDuringDeferredPeriod { get; set; }

    public double EndowmentAmountAfterDeferredPeriod { get; set; }

    public string PremiumFrequency { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public bool EndorsementMade { get; set; }

    public string ProductCategory { get; set; } = null!;
}
