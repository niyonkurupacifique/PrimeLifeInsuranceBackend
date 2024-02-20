using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewForDigitalSavingsPayment
{
    public string PolicyNumber { get; set; } = null!;

    public string? ProofOfPayment { get; set; }

    public DateTime? PaymentDate { get; set; }

    public double? AmountPayed { get; set; }

    public string? UserId { get; set; }
}
