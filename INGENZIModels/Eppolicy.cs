﻿using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class Eppolicy
{
    public int IntId { get; set; }

    public string? SchemeNumber { get; set; }

    public string? CustomerNumber { get; set; }

    public string? CustomerName { get; set; }

    public string? PolicyNumber { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? BranchName { get; set; }

    public string? UserName { get; set; }

    public double? Savings { get; set; }

    public string? SalaryOrFixedAmountType { get; set; }

    public double? SalaryOrFixedAmount { get; set; }

    public double? RiskPremium { get; set; }

    public double? DeathTpdsi { get; set; }

    public double? Ppdsi { get; set; }

    public double? DreadDeseaseSi { get; set; }

    public double? FuneralSi { get; set; }

    public double? LossOfRevenueSi { get; set; }

    public double? DeathTpdpremium { get; set; }

    public double? Ppdpremium { get; set; }

    public double? DreadDeseasePremium { get; set; }

    public double? FuneralPremium { get; set; }

    public double? LossOfrevenuePremium { get; set; }

    public double? AllocationOfPremium { get; set; }

    public int? Numberofpyt { get; set; }

    public double? Fees { get; set; }

    public double? TotalPremium { get; set; }

    public double? Salary { get; set; }

    public double? DeathTpdsis { get; set; }

    public double? Ppdsis { get; set; }

    public double? DreadDeseaseSis { get; set; }

    public double? FuneralSis { get; set; }

    public double? LossOfRevenueSis { get; set; }

    public bool ActiveStatus { get; set; }
}
