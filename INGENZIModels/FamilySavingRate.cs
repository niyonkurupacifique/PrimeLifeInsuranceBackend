using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class FamilySavingRate
{
    public int IdRecord { get; set; }

    public double? AnnualInterestRate { get; set; }

    public double? ManagementFeesRate { get; set; }

    public double? CommissionRate { get; set; }

    public bool? Status { get; set; }

    public DateOnly? RecordDate { get; set; }

    public string? UserName { get; set; }
}
