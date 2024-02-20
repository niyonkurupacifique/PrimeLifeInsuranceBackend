using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewSmsDigitalPendingPayment
{
    public int IdRecord { get; set; }

    public string TransactionId { get; set; } = null!;

    public string? PhonNumber { get; set; }

    public string Status { get; set; } = null!;

    public string? Product { get; set; }

    public string? ExternalReference { get; set; }

    public string? ReferenceId { get; set; }

    public double? Amount { get; set; }

    public DateTime RecordedDate { get; set; }
}
