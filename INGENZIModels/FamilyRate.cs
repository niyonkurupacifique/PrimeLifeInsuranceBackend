using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class FamilyRate
{
    public int IdRecord { get; set; }

    public string CategoryId { get; set; } = null!;

    public string CategoryType { get; set; } = null!;

    public double PolicyholderSumInsured { get; set; }

    public double SpouseSumInsured { get; set; }

    public double KidsSumInsured { get; set; }

    public double? MonthlyPremium { get; set; }

    public double? AnnualyPremium { get; set; }

    public double? MonthlyMinSavings { get; set; }

    public double? AnnualyMinSavings { get; set; }

    public double? BaseKids { get; set; }

    public double? MonthlyAddPremium { get; set; }

    public double? AnnualyAddPremium { get; set; }

    public bool Status { get; set; }

    public DateOnly? RecordDate { get; set; }

    public string? UserName { get; set; }

    public double? CommissionRate { get; set; }

    public double? ParentSumInsured { get; set; }

    public double? MonthlyAddPmParent { get; set; }

    public double? FuneralAmount { get; set; }

    public double? HospitalAmount { get; set; }

    public double? DriverEmergencyAmount { get; set; }
}
