using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class FamilyEpiInvoice
{
    public int IdRecord { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string ReferencePay { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public DateTime PaymentPeriod { get; set; }

    public double? Premiums { get; set; }
}
