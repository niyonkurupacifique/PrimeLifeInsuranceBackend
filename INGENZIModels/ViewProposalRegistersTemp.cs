using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewProposalRegistersTemp
{
    public int IdRecord { get; set; }

    public string ProposalNumber { get; set; } = null!;

    public string? CustomerCode { get; set; }

    public string? SchemeId { get; set; }

    public DateOnly? ProposalDate { get; set; }

    public double Premium { get; set; }

    public double? RiskPremium { get; set; }

    public double? SavingsPremium { get; set; }

    public string? PremiumFrequency { get; set; }

    public int PolicyTermYears { get; set; }

    public string? ProductCategory { get; set; }

    public string? CycleAssured { get; set; }

    public double? BenefitsInYears { get; set; }

    public double? SumInsured { get; set; }

    public double? TotalSumInsured { get; set; }

    public string? BenefitPaymentFrequency { get; set; }

    public string? BusinessChannel { get; set; }

    public string? DistributionChannelId { get; set; }

    public string? PaymentMode { get; set; }

    public string? Institutions { get; set; }

    public string? AccountNumber { get; set; }

    public string? ReciptingBankId { get; set; }

    public DateOnly? DueDate { get; set; }

    public DateOnly? RecordedDate { get; set; }

    public string? UserName { get; set; }

    public bool? Converted { get; set; }

    public DateOnly? ConvertedDate { get; set; }

    public string? Product { get; set; }

    public string? PolicyNumber { get; set; }

    public bool? SignedAndReturned { get; set; }

    public DateOnly? ReturnedDate { get; set; }

    public bool? Cancelled { get; set; }

    public DateOnly? CancelledDate { get; set; }

    public string? CancelledRaison { get; set; }

    public string? StaffId { get; set; }

    public double? Commissions { get; set; }

    public string? NextOfKinNames { get; set; }

    public string? Relationship { get; set; }

    public string? ChildCovered { get; set; }

    public bool? DeathTpd { get; set; }

    public bool? Ppd { get; set; }

    public bool? DreadDesease { get; set; }

    public bool? Funeral { get; set; }

    public bool? LossOfRevenue { get; set; }

    public bool? SpouceCover { get; set; }

    public string? IdDocumentNumber { get; set; }

    public int? Leng { get; set; }
}
