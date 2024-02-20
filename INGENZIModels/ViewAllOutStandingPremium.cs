using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewAllOutStandingPremium
{
    public string? CustomerCode { get; set; }

    public string? FullName { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string? PolicyNumber { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public string? ProductType { get; set; }

    public string? PolicyStatus { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public double? RiskPremium { get; set; }

    public double? AmountPayed { get; set; }

    public double? Outstanding { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string? Schemes { get; set; }
}
