using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewProposalRegister
{
    public string CustomerCode { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string? DateOfBirth { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string ProposalNumber { get; set; } = null!;

    public string? ProposalDate { get; set; }

    public string? RecordedDate { get; set; }

    public string? DueDate { get; set; }

    public string? Product { get; set; }

    public double Premium { get; set; }

    public string? PremiumFrequency { get; set; }

    public int PolicyTermYears { get; set; }

    public string? ProductCategory { get; set; }

    public double? BenefitsInYears { get; set; }

    public double? SumInsured { get; set; }

    public string? BenefitPaymentFrequency { get; set; }

    public string? BusinessChannel { get; set; }

    public string? DistributionChannelId { get; set; }

    public string? ChannelName { get; set; }

    public string? PaymentMode { get; set; }

    public string? Institutions { get; set; }

    public string? AccountNumber { get; set; }

    public string? UserName { get; set; }

    public bool? Converted { get; set; }

    public string? ConvertedDate { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? PolicyNumber { get; set; }

    public bool? SignedAndReturned { get; set; }

    public DateTime? ReturnedDate { get; set; }

    public bool? Cancelled { get; set; }

    public DateTime? CancelledDate { get; set; }

    public string? CancelledRaison { get; set; }

    public string? StaffId { get; set; }

    public string? Email { get; set; }

    public DateTime? ProposalDate1 { get; set; }

    public string? UserNamePolicy { get; set; }

    public string? MemberFullName { get; set; }

    public string? Relationship { get; set; }

    public string? NextOfKin { get; set; }

    public string? SchemeId { get; set; }
}
