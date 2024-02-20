using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class MomoStatment
{
    public string? TransactionId { get; set; }

    public string? ExternalTransactionId { get; set; }

    public DateTime? Date { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public string? FromNumber { get; set; }

    public string? FromName { get; set; }

    public string? ToNumber { get; set; }

    public string? ToName { get; set; }

    public string? ToMessage { get; set; }

    public double? Amount { get; set; }
}
