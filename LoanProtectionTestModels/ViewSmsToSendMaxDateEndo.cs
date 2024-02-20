using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewSmsToSendMaxDateEndo
{
    public string? SchemeName { get; set; }

    public string? CustomerCode { get; set; }

    public string FullName { get; set; } = null!;

    public DateOnly? DateOfBirth { get; set; }

    public string? Gender { get; set; }

    public string? PolicyNumber { get; set; }

    public int? ProfitSharing { get; set; }

    public int? Bonus { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public double Contribution { get; set; }

    public double AnnualPremium { get; set; }

    public double? TotalContribution { get; set; }

    public int? Term { get; set; }

    public double? SumAssured { get; set; }

    public double? SurrenderValue { get; set; }

    public bool? Surrendered { get; set; }

    public bool? Suspended { get; set; }

    public string? PhoneNumber { get; set; }

    public double? OutstandingAmount { get; set; }

    public DateTime? MaxPaymentDate { get; set; }

    public string? PaymentChannel { get; set; }

    public string? Channel { get; set; }

    public bool PolicyStatus { get; set; }
}
