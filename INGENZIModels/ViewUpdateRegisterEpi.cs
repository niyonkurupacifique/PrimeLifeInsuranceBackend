using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewUpdateRegisterEpi
{
    public string CustomerCode { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string? SchemeNumber { get; set; }

    public string? PolicyNumber { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? UserName { get; set; }

    public double? Savings { get; set; }

    public double? RiskPremium { get; set; }

    public double? TotalPremium { get; set; }
}
