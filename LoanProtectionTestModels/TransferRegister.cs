using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class TransferRegister
{
    public int IdRecord { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public string ServiceProvider { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string InternalTransactionId { get; set; } = null!;

    public double CurrentFundValue { get; set; }

    public double MaxPossibleAmount { get; set; }

    public double RequestedAmount { get; set; }

    public double TransferedAmount { get; set; }

    public double Fees { get; set; }

    public DateTime TransactionDate { get; set; }

    public string? ServiceProviderTransactionId { get; set; }

    public bool Closed { get; set; }
}
