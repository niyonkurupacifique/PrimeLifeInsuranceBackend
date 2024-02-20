using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewProposalCoverter
{
    public string? CustomerCode { get; set; }

    public string? SchemeId { get; set; }

    public string FullName { get; set; } = null!;

    public string ProposalNumber { get; set; } = null!;

    public DateTime? ProposalDate { get; set; }

    public double Premium { get; set; }

    public double? RiskPremium { get; set; }

    public double? SavingsPremium { get; set; }

    public string? PremiumFrequency { get; set; }

    public int PolicyTermYears { get; set; }

    public string? ProductCategory { get; set; }

    public string? CycleAssured { get; set; }

    public double? BenefitsInYears { get; set; }

    public double? SumInsured { get; set; }

    public string? BenefitPaymentFrequency { get; set; }

    public string? BusinessChannel { get; set; }

    public string? DistributionChannelId { get; set; }

    public string? ChannelName { get; set; }

    public string? PaymentMode { get; set; }

    public string? Institutions { get; set; }

    public string? AccountNumber { get; set; }

    public string? ReciptingBankId { get; set; }

    public DateOnly? DueDate { get; set; }

    public DateTime? RecordedDate { get; set; }

    public string? UserName { get; set; }

    public bool? Converted { get; set; }

    public DateTime? ConvertedDate { get; set; }

    public string? Product { get; set; }

    public string? PolicyNumber { get; set; }

    public bool? SignedAndReturned { get; set; }

    public DateTime? ReturnedDate { get; set; }

    public bool? Cancelled { get; set; }

    public DateTime? CancelledDate { get; set; }

    public string? CancelledRaison { get; set; }

    public string? StaffId { get; set; }

    public double? Commissions { get; set; }

    public string? NextOfKinNames { get; set; }

    public string? Relationship { get; set; }

    public string? ChildCovered { get; set; }

    public decimal? DeathTpd { get; set; }

    public decimal? Ppd { get; set; }

    public decimal? DreadDesease { get; set; }

    public decimal? Funeral { get; set; }

    public decimal? LossOfRevenue { get; set; }

    public decimal? SpouceCover { get; set; }

    public double? TotalSumInsured { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? PhoneNumber1 { get; set; }

    public int NumberOfKids { get; set; }

    public int NumberDirectParent { get; set; }

    public int NumberParentLaw { get; set; }

    public bool? ReinsuranceNeeded { get; set; }

    public bool? MedicalNeeded { get; set; }
}
