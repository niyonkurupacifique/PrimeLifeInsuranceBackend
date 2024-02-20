using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class LoanProtectionReceiptingBank
{
    public int IdRecord { get; set; }

    public string AccountCode { get; set; } = null!;

    public string? BankName { get; set; }
}
