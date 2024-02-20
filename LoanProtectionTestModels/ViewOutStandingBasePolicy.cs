using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewOutStandingBasePolicy
{
    public string? PolicyNumber { get; set; }

    public string FullName { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string ProductName { get; set; } = null!;

    public int? PolicyStatus { get; set; }

    public string? PaymentChannel { get; set; }

    public string? Channel { get; set; }

    public string? PaymentMode { get; set; }

    public double? Contribution { get; set; }

    public double? TotalContribution { get; set; }

    public double? OutstandingAmount { get; set; }

    public DateTime? MaxPaymentDate { get; set; }
}
