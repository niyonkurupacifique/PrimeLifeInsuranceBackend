using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewEpiPolicyWithoutPayment
{
    public string CustomerCode { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string SchemeId { get; set; } = null!;

    public string? EffectiveDate { get; set; }

    public string? MaturityDate { get; set; }

    public int PolicyTermYears { get; set; }

    public string? PolicyComponentType { get; set; }

    public string? ProductCategory { get; set; }

    public string? PremiumFrequency { get; set; }

    public double RiskPremium { get; set; }

    public string? PaymentPeriod { get; set; }

    public string? RecordedDate { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string? SchemeName { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string? VendorId { get; set; }

    public string? ChannelName { get; set; }
}
