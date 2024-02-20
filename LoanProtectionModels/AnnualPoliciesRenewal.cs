using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class AnnualPoliciesRenewal
{
    public string CustomerCode { get; set; } = null!;

    public string Names { get; set; } = null!;

    public string BankName { get; set; } = null!;

    public string Branch { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public DateTime PolicyDate { get; set; }

    public DateTime CoverStartDate { get; set; }

    public DateTime CoverEndDate { get; set; }

    public DateTime? LoanEndDate { get; set; }

    public double Premium { get; set; }

    public double Fees { get; set; }

    public double TotalPremium { get; set; }

    public double LoanAmount { get; set; }

    public string? Email { get; set; }

    public string Phone { get; set; } = null!;

    public string? PayFrequency { get; set; }
}
