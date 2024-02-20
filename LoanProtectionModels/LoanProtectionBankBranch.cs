using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class LoanProtectionBankBranch
{
    public int IdRecord { get; set; }

    public string IdBank { get; set; } = null!;

    public string IdBankBranch { get; set; } = null!;

    public string BranchName { get; set; } = null!;

    public string? Province { get; set; }

    public string? District { get; set; }

    public string? Sector { get; set; }

    public string? Phone { get; set; }

    public string? ContactPerson { get; set; }

    public string? ContactPersonNumber { get; set; }

    public double CommissionRate { get; set; }

    public double? MaxAmount { get; set; }

    public virtual LoanProtectionBank IdBankNavigation { get; set; } = null!;
}
