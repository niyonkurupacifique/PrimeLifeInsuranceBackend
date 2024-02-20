using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewSavingsPytStatement
{
    public string CustomerCode { get; set; } = null!;

    public string? LastName { get; set; }

    public string? MiddleName { get; set; }

    public string? FirstName { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string PolicyNumberChild { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public double Contribution { get; set; }

    public int Term { get; set; }

    public string ReferencePay { get; set; } = null!;

    public string PaymentChannel { get; set; } = null!;

    public string PaymentSource { get; set; } = null!;

    public DateTime? PaymentDate { get; set; }

    public double? AmountPayed { get; set; }

    public string? ProofOfPayment { get; set; }
}
