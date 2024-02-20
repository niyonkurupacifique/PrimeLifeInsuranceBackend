using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewForDigitalEpiPayment
{
    public string PolicyNumber { get; set; } = null!;

    public string ProofOfPayment { get; set; } = null!;

    public DateTime PaymentDate { get; set; }

    public double AmountPayed { get; set; }

    public string UserId { get; set; } = null!;
}
