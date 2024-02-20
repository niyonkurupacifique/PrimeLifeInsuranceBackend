using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewAllPoliciesPsMainEndoDetailsNew
{
    public string? NexEndorsement { get; set; }

    public int IdRecord { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string PolicyNumberChild { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDateEndo { get; set; }

    public double Contribution { get; set; }

    public bool EndorsementMade { get; set; }

    public bool Cancelled { get; set; }

    public bool Surrendered { get; set; }

    public bool Suspended { get; set; }

    public string FullNames { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? Email { get; set; }

    public string? Gender { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string SchemeId { get; set; } = null!;

    public string SchemeName { get; set; } = null!;

    public string VendorCode { get; set; } = null!;

    public string? VendorName { get; set; }

    public string PolicyType { get; set; } = null!;

    public int Term { get; set; }

    public string PaymentMode { get; set; } = null!;

    public double CommissionRate { get; set; }

    public double InterestRate { get; set; }

    public double ManagementFees { get; set; }

    public double InstallmentFees { get; set; }
}
