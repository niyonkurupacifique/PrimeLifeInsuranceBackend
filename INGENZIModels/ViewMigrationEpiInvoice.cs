using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewMigrationEpiInvoice
{
    public string? CustomerCode { get; set; }

    public string? ReferencePay { get; set; }

    public string? PolicyNumber { get; set; }

    public DateTime? PaymentPeriod { get; set; }

    public double Premiums { get; set; }
}
