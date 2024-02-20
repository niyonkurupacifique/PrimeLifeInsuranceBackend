using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewAllPoliciesEducation
{
    public string Country { get; set; } = null!;

    public string LeBook { get; set; } = null!;

    public string AccountNo { get; set; } = null!;

    public string? AccountName { get; set; }

    public string VisionOuc { get; set; } = null!;

    public string VisionSbu { get; set; } = null!;

    public string AccountStatus { get; set; } = null!;

    public DateTime? AccountStatusDate { get; set; }

    public string CustomerId { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public string VisionGl { get; set; } = null!;

    public string AccountType { get; set; } = null!;

    public DateTime? AccountOpenDate { get; set; }

    public DateTime? AccountClosingDate { get; set; }

    public string PublicSectorCode { get; set; } = null!;

    public string InstitutionalSectorCode { get; set; } = null!;

    public string RenewalPolicyFlag { get; set; } = null!;

    public int NumOfBeneficiaries { get; set; }

    public int PolicyWrittenThru { get; set; }

    public DateTime? DateLastModified { get; set; }

    public DateTime? DatePolicy1 { get; set; }

    public string? UserName { get; set; }

    public string Products { get; set; } = null!;

    public double? Premium { get; set; }

    public string? ChannelType { get; set; }

    public string? DistributionChannelId { get; set; }

    public string? ChannelName { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public string? SchemId { get; set; }

    public string? SchemeName { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? PhoneNumber1 { get; set; }

    public double? AmtAfterDiffered { get; set; }

    public int? PolicyAge { get; set; }

    public bool? EndorsementMade { get; set; }

    public string PolicyNumberEndo { get; set; } = null!;

    public string? Email { get; set; }

    public string? Gender { get; set; }

    public DateTime? DateOfBirth { get; set; }
}
