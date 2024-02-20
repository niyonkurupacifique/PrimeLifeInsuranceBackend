using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewAllPoliciesFamily
{
    public string Country { get; set; } = null!;

    public string LeBook { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string? AccountName { get; set; }

    public string VisionOuc { get; set; } = null!;

    public string VisionSbu { get; set; } = null!;

    public string AccountStatus { get; set; } = null!;

    public DateTime? AccountStatusDate { get; set; }

    public string? CustomerId { get; set; }

    public string Currency { get; set; } = null!;

    public string VisionGl { get; set; } = null!;

    public string AccountType { get; set; } = null!;

    public DateTime? AccountOpenDate { get; set; }

    public DateTime? AccountClosingDate { get; set; }

    public string PublicSectorCode { get; set; } = null!;

    public string InstitutionalSectorCode { get; set; } = null!;

    public string RenewalPolicyFlag { get; set; } = null!;

    public int? NumOfBeneficiaries { get; set; }

    public int PolicyWrittenThru { get; set; }

    public DateTime? DateLastModified { get; set; }

    public DateTime? RecordedDate { get; set; }

    public string? UserName { get; set; }

    public string Products { get; set; } = null!;

    public double RiskPremium { get; set; }

    public string? ChannelType { get; set; }

    public string? VendorId { get; set; }

    public string? ChannelName { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public string SchemeId { get; set; } = null!;

    public string? SchemeName { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? PhoneNumber1 { get; set; }

    public double? SumInsured { get; set; }

    public int? PolicyAge { get; set; }

    public string EndorsementMade { get; set; } = null!;

    public string PolicyNumberEndo { get; set; } = null!;

    public string? Email { get; set; }

    public string? Gender { get; set; }

    public DateTime? DateOfBirth { get; set; }
}
