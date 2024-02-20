using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class OtherPaymentsTransactionsRegister
{
    public int IdRecord { get; set; }

    public string InternalTransactionId { get; set; } = null!;

    public string Product { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public double TotalAmount { get; set; }

    public double Fees { get; set; }

    public DateOnly TransactionDate { get; set; }

    public string Account { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string PaymentMode { get; set; } = null!;

    public bool Paid { get; set; }

    public bool Integrated { get; set; }

    public string? Comments { get; set; }
}
