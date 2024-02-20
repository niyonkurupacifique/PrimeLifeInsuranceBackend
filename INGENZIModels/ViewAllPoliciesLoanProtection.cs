using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewAllPoliciesLoanProtection
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

    public double TotalPremium { get; set; }

    public string? BusinessChannel { get; set; }

    public string? VendorCode { get; set; }

    public string? VendorName { get; set; }

    public string? PaymentChannel { get; set; }

    public string BankNames { get; set; } = null!;

    public string IdBankBranch { get; set; } = null!;

    public string BankNamesScheme { get; set; } = null!;

    public string? IdDocumentNumber { get; set; }

    public string? PhoneNumber1 { get; set; }

    public double LoanAmount { get; set; }

    public int? PolicyAge { get; set; }

    public string EndorsementMade { get; set; } = null!;

    public string PolicyNumberEndo { get; set; } = null!;

    public string? Email { get; set; }

    public string? Gender { get; set; }

    public DateTime? DateOfBirth { get; set; }
}
