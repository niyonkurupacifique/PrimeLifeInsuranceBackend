using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class AirtelCallBackLog
{
    public int IdRecord { get; set; }

    public string? TransactionId { get; set; }

    public string? ExternalTransactionId { get; set; }

    public string? TransactionStatus { get; set; }

    public string? Message { get; set; }

    public double? Amount { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Product { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? PolicyNumber { get; set; }
}
