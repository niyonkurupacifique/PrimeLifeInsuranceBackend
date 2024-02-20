using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class SingleInvoiceRegister
{
    public int IdRecord { get; set; }

    public string InvoiceNumber { get; set; } = null!;

    public string IdBank { get; set; } = null!;

    public DateOnly TransactionDate { get; set; }

    public bool Integrated { get; set; }

    public DateOnly RecordedDate { get; set; }

    public string? Username { get; set; }

    public string? ReceiptingAccount { get; set; }
}
