using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class DataNonGroup
{
    public string PolicyNumber { get; set; } = null!;

    public string IdDocumentNumber { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public double Contribution { get; set; }

    public int Term { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string ReferencePay { get; set; } = null!;

    public string PaymentChannel { get; set; } = null!;

    public DateTime? PaymentDate { get; set; }

    public double AmountPayed { get; set; }

    public string ProofOfPayment { get; set; } = null!;

    public string Comments { get; set; } = null!;

    public DateTime PolicyDate { get; set; }

    public double InterestRate { get; set; }

    public string PaymentMode { get; set; } = null!;

    public string BenefitsPaymentsMode { get; set; } = null!;

    public string? VendorName { get; set; }

    public string? VendorType { get; set; }
}
