using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class SavingsQuotation
{
    public int IdRecord { get; set; }

    public string QuotationId { get; set; } = null!;

    public string IdDocumentNumber { get; set; } = null!;

    public string Names { get; set; } = null!;

    public DateOnly DateOfBirth { get; set; }

    public string Product { get; set; } = null!;

    public string PaymentFrequency { get; set; } = null!;

    public double? Contribution { get; set; }

    public double InterestRate { get; set; }

    public double ManagementFees { get; set; }

    public double InstallementFees { get; set; }

    public double Commissions { get; set; }

    public int Term { get; set; }

    public double SumAssured { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public string Username { get; set; } = null!;

    public bool Converted { get; set; }
}
