using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class LoanProtectionInsuranceCompanyBranch
{
    public int IdRecord { get; set; }

    public string InsuranceBranchCode { get; set; } = null!;

    public string IdInsuranceCompany { get; set; } = null!;

    public string BranchName { get; set; } = null!;
}
