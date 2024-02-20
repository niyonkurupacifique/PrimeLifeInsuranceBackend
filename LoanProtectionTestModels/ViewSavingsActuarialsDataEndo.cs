using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewSavingsActuarialsDataEndo
{
    public string SchemeName { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string PolicyNumberChild { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int Term { get; set; }

    public double SumAssured { get; set; }

    public bool Surrendered { get; set; }

    public bool Suspended { get; set; }

    public string? PhoneNumber { get; set; }

    public int Outsatnding { get; set; }

    public bool Cancelled { get; set; }

    public int IdRecord { get; set; }

    public string IdentityRecord { get; set; } = null!;

    public int Period { get; set; }

    public string? SchemeNumber { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public double Contribution { get; set; }

    public double ManagementFees { get; set; }

    public double InstallmentFees { get; set; }

    public double Rate { get; set; }

    public double Commission { get; set; }

    public double PensionAmt { get; set; }

    public double InvestedPremium { get; set; }

    public double AcquiredValue { get; set; }

    public DateOnly? DueDate { get; set; }

    public string Username { get; set; } = null!;

    public string PolicyType { get; set; } = null!;

    public string PaymentMode { get; set; } = null!;
}
