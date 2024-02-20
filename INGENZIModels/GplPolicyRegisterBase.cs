using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class GplPolicyRegisterBase
{
    public int IdRecord { get; set; }

    public string PolicyNumberBase { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string? SchemeName { get; set; }

    public string? MainInsurer { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public int? PolicyTermYears { get; set; }

    public string? ProductCategory { get; set; }

    public string? PremiumFrequency { get; set; }

    public string? PricingMethod { get; set; }

    public double? CommissionRate { get; set; }

    public double? ManagementFee { get; set; }

    public double? DeathTpdrate { get; set; }

    public double? Ppdrate { get; set; }

    public double? LossOfIncomeRate { get; set; }

    public double? DreadDiseasesRate { get; set; }

    public double? FuneralFeesRate { get; set; }

    public double? MedicalExpensesRate { get; set; }

    public double? AccidentalDeathRate { get; set; }

    public double? DeathTpdrateSpouse { get; set; }

    public double? PpdrateSpouse { get; set; }

    public double? DreadDiseasesRateSpouse { get; set; }

    public double? FuneralFeesRateSpouse { get; set; }

    public double? MedicalExpensesRateSpouse { get; set; }

    public double? AccidentalDeathRateSpouse { get; set; }

    public double? FuneralFeesRateKids { get; set; }

    public double? MedicalExpensesRateKids { get; set; }

    public double? AccidentalDeathRateKids { get; set; }

    public double? DiscountLoadingRate { get; set; }

    public string? BusinessChannel { get; set; }

    public string? VendorId { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public bool? Claimed { get; set; }

    public bool? Cancelled { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? RecordedDate { get; set; }

    public string? UserName { get; set; }
}
