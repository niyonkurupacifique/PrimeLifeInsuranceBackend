using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewProposalSaving
{
    public string? CustomerCode { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? SchemeId { get; set; }

    public string FullName { get; set; } = null!;

    public string ProposalNumber { get; set; } = null!;

    public DateTime? ProposalDate { get; set; }

    public double Premium { get; set; }

    public string? PremiumFrequency { get; set; }

    public int PolicyTermYears { get; set; }

    public double? SumInsured { get; set; }

    public string? BusinessChannel { get; set; }

    public string? DistributionChannelId { get; set; }

    public string? PaymentMode { get; set; }

    public string? Institutions { get; set; }

    public DateOnly? DueDate { get; set; }

    public DateTime? RecordedDate { get; set; }

    public string? UserName { get; set; }

    public bool? Converted { get; set; }

    public DateTime? ConvertedDate { get; set; }

    public string? Product { get; set; }

    public string? PhoneNumber1 { get; set; }

    public bool? ReinsuranceNeeded { get; set; }

    public bool? MedicalNeeded { get; set; }
}
