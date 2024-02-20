using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class BnrErrorLog
{
    public int AutoId { get; set; }

    public string? TransactionId { get; set; }

    public string? TransactionType { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? ErrorDescription { get; set; }
}
