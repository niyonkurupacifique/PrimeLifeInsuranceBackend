using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class OnlinePaymentTransaction
{
    public int IdRecord { get; set; }

    public string? TransactionId { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Product { get; set; }

    public string? ExternalReference { get; set; }

    public string ReferenceId { get; set; } = null!;

    public double? Amount { get; set; }

    public DateTime RecordedDate { get; set; }

    public string? PolicyNumber { get; set; }
}
