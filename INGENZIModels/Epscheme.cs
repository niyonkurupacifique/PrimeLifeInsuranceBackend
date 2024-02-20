using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class Epscheme
{
    public int AutoId { get; set; }

    public bool DeathTpd { get; set; }

    public bool Ppd { get; set; }

    public bool DreadDesease { get; set; }

    public bool LossOfRevenue { get; set; }

    public bool FuneralFees { get; set; }

    public double SumInsuredMonths { get; set; }

    public double PercentageSavingSalary { get; set; }

    public string SchemeNumber { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public DateTime? CreationDate { get; set; }

    public string UserName { get; set; } = null!;

    public bool Saving { get; set; }

    public string BranchName { get; set; } = null!;

    public string PolicyPytPlan { get; set; } = null!;

    public int NumberOfPyt { get; set; }

    public string? Channel { get; set; }

    public string? Advisor { get; set; }

    public string? PremiumFrequency { get; set; }

    public string? PaymentChannel { get; set; }

    public string? PaymentDetails { get; set; }

    public int SalaryTimes { get; set; }
}
