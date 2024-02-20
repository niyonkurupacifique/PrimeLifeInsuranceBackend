using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewProposalDetail
{
    public string ProposalNumber { get; set; } = null!;

    public DateTime? ProposalDate { get; set; }

    public string? CustomerCode { get; set; }

    public string FullName { get; set; } = null!;

    public string? Product { get; set; }

    public double Premium { get; set; }

    public string? PremiumFrequency { get; set; }

    public double? SumInsured { get; set; }

    public string? BusinessChannel { get; set; }

    public string? DistributionChannelId { get; set; }

    public string? ChannelName { get; set; }

    public string? PaymentMode { get; set; }

    public string? Institutions { get; set; }

    public string? AccountNumber { get; set; }

    public DateOnly? DueDate { get; set; }

    public DateTime? RecordedDate { get; set; }

    public string? Salutation { get; set; }

    public string? Gender { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? MartialStatus { get; set; }

    public string? Nationality { get; set; }

    public string? IdDocumentType { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? IssuedProvince { get; set; }

    public string? IssuedDistrict { get; set; }

    public string? IssuedSector { get; set; }

    public string? IssuedCell { get; set; }

    public string? IssuedVillage { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string? PolicyNumber { get; set; }

    public string? SavingPolicy { get; set; }
}
