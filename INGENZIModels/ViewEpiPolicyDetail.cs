using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewEpiPolicyDetail
{
    public string PolicyNumber { get; set; } = null!;

    public string SchemeId { get; set; } = null!;

    public string? FullName { get; set; }

    public string? DistributionChannelId { get; set; }

    public string? ChannelType { get; set; }

    public string? ChannelName { get; set; }

    public string? CustomerCode { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public int PolicyTermYears { get; set; }

    public string? PolicyComponentType { get; set; }

    public string? ProductCategory { get; set; }

    public string? PremiumFrequency { get; set; }

    public double RiskPremium { get; set; }

    public double? CommissionOnRiskPremium { get; set; }

    public double SavingPremium { get; set; }

    public int? SavingsAnnualInterestRate { get; set; }

    public int? SavingsManagementFees { get; set; }

    public double TotalPremium { get; set; }

    public double? DeathTpdsi { get; set; }

    public double? FuneralSi { get; set; }

    public string? Salutation { get; set; }

    public string? Gender { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? MartialStatus { get; set; }

    public string? Nationality { get; set; }

    public string? IdDocumentType { get; set; }

    public string? IssuedProvince { get; set; }

    public string? IssuedDistrict { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string? IssuedSector { get; set; }

    public string? IssuedCell { get; set; }

    public string? IssuedVillage { get; set; }

    public string? SavingPolicyNumber { get; set; }

    public string? UserName { get; set; }

    public string? Expr1 { get; set; }

    public string? SchemeName { get; set; }

    public double? FuneralAmount { get; set; }

    public double? HospitalAmount { get; set; }

    public double? DriverEmergencyAmount { get; set; }

    public double? SpouseSumInsured { get; set; }

    public double? KidsSumInsured { get; set; }

    public double? Ppdsi { get; set; }

    public double? DreadDeseaseSi { get; set; }

    public double? LossOfRevenueSi { get; set; }

    public double? SpouseCoverSi { get; set; }

    public string PolicyStatus { get; set; } = null!;

    public string? ProposalNumber { get; set; }
}
