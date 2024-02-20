using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewIkiminaAllPayment
{
    public string CustomerCode { get; set; } = null!;

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? PhoneNumber { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string PolicyNumberChild { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public double Contribution { get; set; }

    public DateTime RecordDate { get; set; }

    public string? Channel { get; set; }

    public bool Cancelled { get; set; }

    public string? SchemeNumber { get; set; }

    public string ReferencePay { get; set; } = null!;

    public string PaymentChannel { get; set; } = null!;

    public string PaymentSource { get; set; } = null!;

    public DateTime? PaymentDate { get; set; }

    public double? AmountPayed { get; set; }

    public string? ProofOfPayment { get; set; }

    public string? UserId { get; set; }

    public int? ReportingYear { get; set; }

    public int? ReportingMonth { get; set; }

    public string? YearMonth { get; set; }
}
