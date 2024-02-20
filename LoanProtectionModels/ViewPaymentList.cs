using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewPaymentList
{
    public string CustomerCode { get; set; } = null!;

    public string CutomerNames { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public double Premium { get; set; }

    public double Fees { get; set; }

    public double Total { get; set; }

    public DateTime TransactionDate { get; set; }

    public bool? Paid { get; set; }

    public string Bank { get; set; } = null!;

    public string Branch { get; set; } = null!;

    public string IdBank { get; set; } = null!;

    public string IdBankBranch { get; set; } = null!;
}
