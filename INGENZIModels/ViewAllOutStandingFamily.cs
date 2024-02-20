using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewAllOutStandingFamily
{
    public string PolicyNumber { get; set; } = null!;

    public string? FullName { get; set; }

    public string? PhoneNumber1 { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public string? ProductType { get; set; }

    public string SubProductType { get; set; } = null!;

    public string? PolicyStatus { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public string? PremiumFrequency { get; set; }

    public double? RiskPremium { get; set; }

    public int NumberOfPayement { get; set; }

    public double TotalAmount { get; set; }

    public double? AmountPayed { get; set; }

    public double? Outstanding { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string? VendorId { get; set; }

    public string? ChannelName { get; set; }

    public string? Idnumber { get; set; }
}
