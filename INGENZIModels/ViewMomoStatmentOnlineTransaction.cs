using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewMomoStatmentOnlineTransaction
{
    public string? TransactionId { get; set; }

    public double? ExternalTransactionId { get; set; }

    public DateTime? Date { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public string? FromNumber { get; set; }

    public string? FromName { get; set; }

    public string? ToName { get; set; }

    public double? Amount { get; set; }

    public int IdRecord { get; set; }

    public string TransactionOnline { get; set; } = null!;

    public string StatusOnline { get; set; } = null!;

    public DateTime RecordedDate { get; set; }
}
