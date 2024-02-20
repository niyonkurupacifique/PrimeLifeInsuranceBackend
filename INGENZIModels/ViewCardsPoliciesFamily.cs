using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewCardsPoliciesFamily
{
    public int IdRecord { get; set; }

    public string FullName { get; set; } = null!;

    public string? IdDocumentNumber { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public int PolicyTermYears { get; set; }

    public string? ProductCategory { get; set; }

    public string? PremiumFrequency { get; set; }

    public double RiskPremium { get; set; }

    public double TotalPremium { get; set; }

    public double PolicyholderSumInsured { get; set; }

    public double SpouseSumInsured { get; set; }

    public double KidsSumInsured { get; set; }

    public double? ParentSumInsured { get; set; }

    public double? FuneralAmount { get; set; }

    public double? HospitalAmount { get; set; }

    public double? DriverEmergencyAmount { get; set; }

    public int? Insurared { get; set; }
}
