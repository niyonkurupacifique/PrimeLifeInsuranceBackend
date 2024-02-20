using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class FamilyDatum
{
    public double? IdRecord { get; set; }

    public string? PolicyNumber { get; set; }

    public string? SchemeId { get; set; }

    public string? CustomerCode { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public double? PolicyTermYears { get; set; }

    public string? PolicyComponentType { get; set; }

    public string? ProductCategory { get; set; }

    public string? PremiumFrequency { get; set; }

    public double? RiskPremium { get; set; }

    public double? CommissionOnRiskPremium { get; set; }

    public double? SavingPremium { get; set; }

    public double? SavingsAnnualInterestRate { get; set; }

    public double? SavingsManagementFees { get; set; }

    public double? TotalPremium { get; set; }

    public string? VendorId { get; set; }

    public double? Claimed { get; set; }

    public double? Surrended { get; set; }

    public string? CreationDate { get; set; }

    public string? RecordedDate { get; set; }

    public string? UserName { get; set; }

    public double? SumInsured { get; set; }

    public double? TotalSumInsured { get; set; }

    public string? SavingPolicyNumber { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }
}
