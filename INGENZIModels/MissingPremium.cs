using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class MissingPremium
{
    public string? PolicyNumber { get; set; }

    public string? ProductType { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public double? Premium { get; set; }

    public string? Schemes { get; set; }

    public DateTime? DateOfPayment { get; set; }
}
