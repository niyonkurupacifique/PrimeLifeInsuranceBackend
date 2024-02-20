using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewStatementDetail
{
    public string PolicyNumber { get; set; } = null!;

    public string ReferencePay { get; set; } = null!;

    public string? ProofOfPayment { get; set; }

    public DateTime? PaymentDate { get; set; }

    public double? AmountPayed { get; set; }

    public string? Comments { get; set; }

    public DateTime? DueDate { get; set; }
}
