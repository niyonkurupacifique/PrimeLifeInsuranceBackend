using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewSingleInvoicePerBank
{
    public double? NetPremium { get; set; }

    public double? Fees { get; set; }

    public double? Total { get; set; }

    public string InvoiceNumber { get; set; } = null!;

    public string IdBank { get; set; } = null!;

    public string? ReceiptingAccount { get; set; }
}
