using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewEpiCombained
{
    public string? PolicyNumber { get; set; }

    public string? CustomerCode { get; set; }

    public string? FullName { get; set; }

    public string? Gender { get; set; }

    public string? EffectiveDate { get; set; }

    public string? MaturityDate { get; set; }

    public int? PolicyTermYears { get; set; }

    public string? PolicyComponentType { get; set; }

    public string? ProductCategory { get; set; }

    public string? PremiumFrequency { get; set; }

    public double? RiskPremium { get; set; }

    public double? CommissionOnRiskPremium { get; set; }

    public double? TotalPremium { get; set; }

    public string? VendorId { get; set; }

    public string? CreationDate { get; set; }

    public string? ChannelName { get; set; }

    public string? ReferencePay { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public string? Branch { get; set; }

    public string? ValidPaymentDate { get; set; }

    public double? AmountPayed { get; set; }

    public string? ProofOfPayment { get; set; }

    public string? Comments { get; set; }

    public string? RecordDate { get; set; }

    public string? UserId { get; set; }

    public string? DateOfBirth { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? ReportingMonths { get; set; }

    public DateTime? PaidDate { get; set; }

    public bool? Claimed { get; set; }

    public bool? Cancelled { get; set; }

    public string? RecordedDate { get; set; }

    public double? DeathTpdsi { get; set; }

    public double? LossOfRevenueSi { get; set; }

    public double? FuneralSi { get; set; }

    public double? SpouseCoverSi { get; set; }

    public double MembersSumInsured { get; set; }

    public double TotalSumInsured { get; set; }
}
