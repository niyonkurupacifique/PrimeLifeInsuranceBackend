using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewEpiPaymentStatement
{
    public string? CustomerCode { get; set; }

    public string? FullName { get; set; }

    public string? PolicyNumber { get; set; }

    public string? SchemeId { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public int? PolicyTermYears { get; set; }

    public string? PolicyComponentType { get; set; }

    public string? ProductCategory { get; set; }

    public string? PremiumFrequency { get; set; }

    public double? RiskPremium { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? RecordedDate { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public string ReferencePay { get; set; } = null!;

    public DateTime PaymentPeriod { get; set; }

    public DateTime? PaymentDate { get; set; }

    public double? AmountPayed { get; set; }

    public string? ProofOfPayment { get; set; }

    public double? Premiums { get; set; }

    public double? TotalAmountDue { get; set; }

    public string? Comments { get; set; }
}
