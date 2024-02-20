using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewInvoiceDuplication
{
    public string PolicyNumber { get; set; } = null!;

    public DateTime PaymentPeriod { get; set; }

    public int? Expr1 { get; set; }

    public int? Expr2 { get; set; }
}
