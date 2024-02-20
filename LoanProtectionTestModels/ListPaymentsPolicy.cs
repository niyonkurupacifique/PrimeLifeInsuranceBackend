using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ListPaymentsPolicy
{
    public string SchemeName { get; set; } = null!;

    public string? CustomerCode { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Gender { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? PhoneNumber { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public double Contribution { get; set; }

    public int Term { get; set; }

    public double SumAssured { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string PaymentMode { get; set; } = null!;

    public string ReferencePay { get; set; } = null!;

    public double? AmountPayed { get; set; }

    public string? ProofOfPayment { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string BenefitsPaymentsMode { get; set; } = null!;

    public double InterestRate { get; set; }

    public double ManagementFees { get; set; }

    public double InstallmentFees { get; set; }

    public double CommissionRate { get; set; }

    public string VendorCode { get; set; } = null!;

    public string? UserId { get; set; }
}
