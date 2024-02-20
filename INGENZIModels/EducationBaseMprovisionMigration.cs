using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class EducationBaseMprovisionMigration
{
    public int IdRecord { get; set; }

    public string? CustomerCode { get; set; }

    public string? PolicyNumber { get; set; }

    public int? PeriodYears { get; set; }

    public double? MathematicalProvision { get; set; }

    public double? SurrenderValue { get; set; }

    public double? MathematicalProvisionTmp { get; set; }

    public DateTime? RecorededDate { get; set; }

    public string? UserName { get; set; }

    public string? BusinessType { get; set; }
}
