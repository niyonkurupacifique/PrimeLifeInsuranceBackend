using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewEducationPolicyDetail
{
    public string PolicyNumber { get; set; } = null!;

    public string? SchemeId { get; set; }

    public string FullName { get; set; } = null!;

    public string DistributionChannelId { get; set; } = null!;

    public string? ChannelType { get; set; }

    public string? ChannelName { get; set; }

    public string CustomerCode { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public double? Premium { get; set; }

    public double? InitialPremium { get; set; }

    public string? PaymentFrequency { get; set; }

    public int? Differed { get; set; }

    public string? EndwomentType { get; set; }

    public int? EndwomentNumber { get; set; }

    public string? CycleAssured { get; set; }

    public double? AmtAfterDiffered { get; set; }

    public double? AmtDuringDiffered { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Salutation { get; set; }

    public string? Gender { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? IdDocumentType { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? ResidenceProvince { get; set; }

    public string? ResidenceDistrict { get; set; }

    public string? ResidenceSector { get; set; }

    public string? ResidenceCell { get; set; }

    public string? ResidenceVillage { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string? SchemeName { get; set; }

    public string PolicyNumberEndo { get; set; } = null!;

    public string? SubscriberId { get; set; }

    public string SubscriberFullName { get; set; } = null!;

    public string? Relationship { get; set; }

    public string? SubscriberIdDocument { get; set; }

    public string? SubscriberPhoneNumber { get; set; }

    public DateTime? StartDateMain { get; set; }

    public string? ProposalNumber { get; set; }
}
