using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewProductionPensionAndSaving
{
    public string IdDocumentNumber { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public string? SchemNumber { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string? PolicyType { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public double Contribution { get; set; }

    public double? SumAssured { get; set; }

    public double? Rate { get; set; }

    public double InterestRate { get; set; }

    public double? PensionRate { get; set; }

    public double? ManagementFees { get; set; }

    public double? InstallmentFees { get; set; }

    public string ReferencePay { get; set; } = null!;

    public string PaymentChannel { get; set; } = null!;

    public DateTime? PaymentDate { get; set; }

    public double AmountPayed { get; set; }

    public string ProofOfPayment { get; set; } = null!;

    public string Comments { get; set; } = null!;

    public string PaymentMode { get; set; } = null!;

    public string BenefitsPaymentsMode { get; set; } = null!;

    public string? VendorName { get; set; }

    public string? VendorType { get; set; }
}
