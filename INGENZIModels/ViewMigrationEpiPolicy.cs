using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewMigrationEpiPolicy
{
    public string? PolicyNumber { get; set; }

    public string SchemeId { get; set; } = null!;

    public string? CustomerCode { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public int? PolicyTermYears { get; set; }

    public string PolicyComponentType { get; set; } = null!;

    public string ProductCategory { get; set; } = null!;

    public string? PremiumFrequency { get; set; }

    public double? RiskPremium { get; set; }

    public double? SavingPremium { get; set; }

    public double? TotalPremium { get; set; }

    public double? CommissionOnRiskPremium { get; set; }

    public string VendorId { get; set; } = null!;

    public bool PolicyStatus { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? RecordedDate { get; set; }

    public string? UserName { get; set; }

    public int? SavingPolicyNumber { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public double? DeathTpdsi { get; set; }

    public double? Ppdsi { get; set; }

    public double? DreadDeseaseSi { get; set; }

    public double? LossOfRevenueSi { get; set; }

    public double? FuneralSi { get; set; }

    public int? NumberOfKids { get; set; }

    public int? NumberDirectParent { get; set; }

    public int? NumberParentLaw { get; set; }

    public bool Claimed { get; set; }

    public bool Cancelled { get; set; }

    public double? SpouseCoverSi { get; set; }
}
