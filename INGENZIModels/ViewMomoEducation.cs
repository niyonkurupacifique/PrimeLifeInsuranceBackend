using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewMomoEducation
{
    public string PolicyNumber { get; set; } = null!;

    public string ReferencePay { get; set; } = null!;

    public string PaymentMode { get; set; } = null!;

    public string PaymentSource { get; set; } = null!;

    public DateTime PaymentDate { get; set; }

    public double AmountPayed { get; set; }

    public string ProofOfPayment { get; set; } = null!;

    public string? UserId { get; set; }
}
