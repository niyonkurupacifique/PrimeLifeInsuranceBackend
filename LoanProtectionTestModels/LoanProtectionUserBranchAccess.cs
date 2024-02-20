using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class LoanProtectionUserBranchAccess
{
    public int IdRecord { get; set; }

    public string Reference { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string InsuranceBranchCode { get; set; } = null!;
}
