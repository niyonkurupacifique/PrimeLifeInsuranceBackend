using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewProposalEducation
{
    public string? CustomerCode { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string FullName { get; set; } = null!;

    public string ProposalNumber { get; set; } = null!;

    public double Premium { get; set; }

    public double? InitialPayment { get; set; }

    public string? PremiumFrequency { get; set; }

    public DateOnly? DueDate { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public int PolicyTermYears { get; set; }

    public double? BenefitsInYears { get; set; }

    public string? CycleAssured { get; set; }

    public string? BusinessChannel { get; set; }

    public string? DistributionChannelId { get; set; }

    public string? PaymentMode { get; set; }

    public string? Institutions { get; set; }

    public DateTime? RecordedDate { get; set; }

    public string? UserName { get; set; }

    public bool? Converted { get; set; }

    public DateTime? ConvertedDate { get; set; }

    public string? Product { get; set; }

    public string? ProductCategory { get; set; }

    public string? PhoneNumber1 { get; set; }

    public DateTime? ProposalDate { get; set; }

    public string? SchemeId { get; set; }

    public bool? ReinsuranceNeeded { get; set; }

    public bool? MedicalNeeded { get; set; }

    public double? RateDeffered { get; set; }

    public string? ChannelName { get; set; }

    public string? NextOfKinNames { get; set; }

    public string? Relationship { get; set; }
}
