using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewNewBusinessSaving
{
    public string? MainPolicyNumber { get; set; }

    public int? MainIdRecord { get; set; }

    public string ReferencePay { get; set; } = null!;

    public string Branch { get; set; } = null!;

    public DateTime? PaymentDate { get; set; }

    public double? AmountPayed { get; set; }

    public string? ProofOfPayment { get; set; }

    public string? Comments { get; set; }

    public DateTime? RecordedDate { get; set; }

    public string? UserId { get; set; }

    public string? ReportingMonths { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string FullName { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string? Channel { get; set; }

    public string SchemeId { get; set; } = null!;

    public string PolicyType { get; set; } = null!;

    public string VendorCode { get; set; } = null!;

    public string? VendorName { get; set; }
}
