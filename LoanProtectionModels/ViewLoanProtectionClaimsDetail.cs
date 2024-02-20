using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewLoanProtectionClaimsDetail
{
    public int IdRecord { get; set; }

    public string ClaimNumber { get; set; } = null!;

    public string ClaimType { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public DateTime ClaimDate { get; set; }

    public DateTime DeclarationDate { get; set; }

    public int PeriodConsumed { get; set; }

    public double LoanAmount { get; set; }

    public double OutstandingAmount { get; set; }

    public double RiskPremium { get; set; }

    public double ErnedPremium { get; set; }

    public double RefundAmount { get; set; }

    public string Username { get; set; } = null!;

    public DateTime RecorDate { get; set; }

    public bool? IsCancelled { get; set; }

    public string IdDocumentNumber { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public double TotalPremium { get; set; }

    public string Bank { get; set; } = null!;

    public string? FullName { get; set; }
}
