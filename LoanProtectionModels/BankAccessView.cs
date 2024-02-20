using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class BankAccessView
{
    public string BankName { get; set; } = null!;

    public string BranchName { get; set; } = null!;

    public string IdBankBranch { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public double CommissionRate { get; set; }

    public string IdBank { get; set; } = null!;
}
