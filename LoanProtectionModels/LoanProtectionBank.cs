using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class LoanProtectionBank
{
    public int IdRecord { get; set; }

    public string IdBank { get; set; } = null!;

    public string BankName { get; set; } = null!;

    public string? Category { get; set; }

    public bool Customized1 { get; set; }

    public virtual ICollection<LoanProtectionBankBranch> LoanProtectionBankBranches { get; set; } = new List<LoanProtectionBankBranch>();
}
