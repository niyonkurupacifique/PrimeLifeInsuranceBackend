using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewAllPoliciesPsMainStattment
{
    public string Country { get; set; } = null!;

    public string LeBook { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string AccountName { get; set; } = null!;

    public string VisionOuc { get; set; } = null!;

    public string VisionSbu { get; set; } = null!;

    public string AccountStatus { get; set; } = null!;

    public DateTime AccountStatusDate { get; set; }

    public string CustomerId { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public string VisionGl { get; set; } = null!;

    public string AccountType { get; set; } = null!;

    public DateTime AccountOpenDate { get; set; }

    public DateTime AccountClosingDate { get; set; }

    public string PublicSectorCode { get; set; } = null!;

    public string InstitutionalSectorCode { get; set; } = null!;

    public string RenewalPolicyFlag { get; set; } = null!;

    public int NumOfBeneficiaries { get; set; }

    public int PolicyWrittenThru { get; set; }

    public DateTime? DateLastModified { get; set; }

    public DateTime RecordDate { get; set; }

    public string UserName { get; set; } = null!;

    public string Products { get; set; } = null!;

    public double Contribution { get; set; }

    public string? VendorType { get; set; }

    public string? VendorCode { get; set; }

    public string? VendorName { get; set; }

    public string? PaymentChannel { get; set; }

    public string? Channel { get; set; }

    public string? SchemeId { get; set; }

    public string? SchemeName { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? PhoneNumber { get; set; }

    public double SumAssured { get; set; }

    public int? PolicyAge { get; set; }

    public bool EndorsementMade { get; set; }

    public string PolicyNumberMain { get; set; } = null!;

    public string? Email { get; set; }

    public string? Gender { get; set; }

    public DateOnly? DateOfBirth { get; set; }
}
