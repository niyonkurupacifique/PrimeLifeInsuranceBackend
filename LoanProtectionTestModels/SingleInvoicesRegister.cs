using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class SingleInvoicesRegister
{
    public int IdRecord { get; set; }

    public string Product { get; set; } = null!;

    public string Account { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public string InvoiceNumber { get; set; } = null!;

    public double Amount { get; set; }

    public DateOnly InvoiceDate { get; set; }

    public bool Integrated { get; set; }

    public string? Comments { get; set; }

    public string Username { get; set; } = null!;
}
