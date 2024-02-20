using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class LoanProtectionAccountNumber
{
    public int IdRecord { get; set; }

    public string IdInsuranceCompany { get; set; } = null!;

    public string IdBankBranch { get; set; } = null!;

    public string AccountNumber { get; set; } = null!;

    public string ReferenceAcc { get; set; } = null!;

    public virtual LoanProtectionInsuranceCompany IdInsuranceCompanyNavigation { get; set; } = null!;
}
