using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewResultApiLoanCoverPolicy
{
    public string IdDoc { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public double Premium { get; set; }

    public double Fees { get; set; }

    public double TotalPremium { get; set; }

    public double? BankCommissions { get; set; }

    public bool? Approved { get; set; }

    public string AccountNumber { get; set; } = null!;

    public string? Reference { get; set; }
}
