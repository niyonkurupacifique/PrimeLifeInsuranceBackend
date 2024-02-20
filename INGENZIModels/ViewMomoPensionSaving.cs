using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewMomoPensionSaving
{
    public string PolicyNumber { get; set; } = null!;

    public string ReferencePay { get; set; } = null!;

    public string PaymentChannel { get; set; } = null!;

    public string PaymentSource { get; set; } = null!;

    public DateTime? PaymentDate { get; set; }

    public double? AmountPayed { get; set; }

    public string? ProofOfPayment { get; set; }

    public string? UserId { get; set; }
}
