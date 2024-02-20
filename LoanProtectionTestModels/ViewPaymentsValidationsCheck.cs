using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewPaymentsValidationsCheck
{
    public int IdRecord { get; set; }

    public string? Uniquekey { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string PolicyNumberChild { get; set; } = null!;

    public string PolicyNumberPayment { get; set; } = null!;

    public string IdentityRecord { get; set; } = null!;

    public string ReferencePay { get; set; } = null!;

    public DateOnly? DueDate { get; set; }

    public DateTime? PaymentDate { get; set; }

    public double? AmountPayed { get; set; }

    public int? ReportingYear { get; set; }

    public int? ReportingMonth { get; set; }

    public string CustomerCode { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDateEndo { get; set; }

    public double Contribution { get; set; }

    public double ContributionInvoice { get; set; }

    public bool EndorsementMade { get; set; }

    public string PolicyStatus { get; set; } = null!;

    public string FullNames { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? Email { get; set; }

    public string SchemeId { get; set; } = null!;

    public string SchemeName { get; set; } = null!;

    public string PaymentStatus { get; set; } = null!;

    public string? SchemeNumber { get; set; }

    public string PaymentChannel { get; set; } = null!;

    public string PaymentSource { get; set; } = null!;

    public string? ProofOfPayment { get; set; }

    public string? Comments { get; set; }

    public string? UserId { get; set; }
}
