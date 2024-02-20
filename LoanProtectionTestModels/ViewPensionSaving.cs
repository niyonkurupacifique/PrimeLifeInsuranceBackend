using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewPensionSaving
{
    public string? SchemeName { get; set; }

    public string? CustomerCode { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? PolicyNumber { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public double? TotalContribution { get; set; }

    public double? Term { get; set; }

    public double? SumAssured { get; set; }

    public double? SurrenderValue { get; set; }

    public double? Surrendered { get; set; }

    public double? Suspended { get; set; }

    public string? PhoneNumber { get; set; }

    public double? OutstandingAmount { get; set; }

    public string? Gender { get; set; }
}
