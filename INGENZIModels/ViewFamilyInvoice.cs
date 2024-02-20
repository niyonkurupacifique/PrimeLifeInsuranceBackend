using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewFamilyInvoice
{
    public string? PolicyNumber { get; set; }

    public string? CustomerCode { get; set; }

    public string? FullName { get; set; }

    public string? EffectiveDate { get; set; }

    public string? MaturityDate { get; set; }

    public string? PremiumFrequency { get; set; }

    public double? RiskPremium { get; set; }

    public double? CommissionOnRiskPremium { get; set; }

    public double? TotalPremium { get; set; }

    public string? ChannelName { get; set; }

    public string? VendorId { get; set; }

    public string? InvoicesNumber { get; set; }

    public DateTime? DueDate { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public string? Branch { get; set; }

    public DateTime? PaymentDate { get; set; }

    public double? AmountPayed { get; set; }

    public string? ProofOfPayment { get; set; }

    public string? Comments { get; set; }

    public string? RecordDate { get; set; }

    public string? UserId { get; set; }
}
