using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class LoanProtectionUserAccess
{
    public int IdRecord { get; set; }

    public string Reference { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string IdBankBranch { get; set; } = null!;

    public virtual LoanProtectionUser UserNameNavigation { get; set; } = null!;
}
