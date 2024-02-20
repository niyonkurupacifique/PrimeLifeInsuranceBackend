using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewStatementPay
{
    public int _ { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string Ref { get; set; } = null!;

    public string Channel { get; set; } = null!;

    public string PaySource { get; set; } = null!;

    public DateTime? Date { get; set; }

    public double? Amount { get; set; }

    public string? Proof { get; set; }

    public string? Comments { get; set; }
}
