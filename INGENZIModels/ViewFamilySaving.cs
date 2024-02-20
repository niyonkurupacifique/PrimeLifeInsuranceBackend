using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewFamilySaving
{
    public string SchemeName { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? Gender { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string PolicyNumberBase { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public double SavingPremium { get; set; }

    public int PolicyTermYears { get; set; }

    public double SumAssured { get; set; }

    public string ReferencePay { get; set; } = null!;

    public string PaymentMode { get; set; } = null!;

    public DateTime PaymentDate { get; set; }

    public double AmountPayed { get; set; }

    public string ProofOfPayment { get; set; } = null!;

    public string Comments { get; set; } = null!;

    public string? UserId { get; set; }

    public string? ChannelName { get; set; }

    public double SavingsAnnualInterestRate { get; set; }

    public double SavingsManagementFees { get; set; }

    public double InstallmentFees { get; set; }

    public double CommissionRate { get; set; }

    public string? ProductCategory { get; set; }

    public string? ReportingMonths { get; set; }
}
