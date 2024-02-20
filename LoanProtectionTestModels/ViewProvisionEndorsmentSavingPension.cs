using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewProvisionEndorsmentSavingPension
{
    public string? SchemeName { get; set; }

    public string? CustomerCode { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? PolicyNumber { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public double? TotalContribution { get; set; }

    public int? Term { get; set; }

    public double? SumAssured { get; set; }

    public double? SurrenderValue { get; set; }

    public bool? Surrendered { get; set; }

    public bool? Suspended { get; set; }

    public string? PhoneNumber { get; set; }

    public double? OutstandingAmount { get; set; }

    public string? Gender { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public double Contribution { get; set; }
}
