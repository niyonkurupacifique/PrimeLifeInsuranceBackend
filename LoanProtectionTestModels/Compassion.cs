using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class Compassion
{
    public string CustomerCode { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public double Contribution { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string ReferencePay { get; set; } = null!;

    public string PaymentChannel { get; set; } = null!;

    public DateTime? PaymentDate { get; set; }

    public double AmountPayed { get; set; }

    public string BranchName { get; set; } = null!;

    public string ProofOfPayment { get; set; } = null!;

    public string Comments { get; set; } = null!;

    public string? VendorType { get; set; }

    public string? VendorName { get; set; }
}
