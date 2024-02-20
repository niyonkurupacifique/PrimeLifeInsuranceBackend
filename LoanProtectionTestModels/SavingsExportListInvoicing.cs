using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class SavingsExportListInvoicing
{
    public int IdRecord { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string Names { get; set; } = null!;

    public string SchemeId { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public double Contribution { get; set; }

    public string InvoiceNumber { get; set; } = null!;

    public int PeriodMonth { get; set; }

    public int PeriodYear { get; set; }

    public DateOnly DueDate { get; set; }

    public bool Paid { get; set; }

    public string Username { get; set; } = null!;

    public string? Product { get; set; }

    public string? PaymentChannel { get; set; }

    public string? Source { get; set; }
}
