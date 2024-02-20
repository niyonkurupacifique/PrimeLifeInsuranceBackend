using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewPolicyRegisterDetail
{
    public string PolicyNumber { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string IdDocumentNumber { get; set; } = null!;

    public string PhoneNumber1 { get; set; } = null!;

    public double TotalPremium { get; set; }

    public bool? Paid { get; set; }

    public string IdBankBranch { get; set; } = null!;
}
