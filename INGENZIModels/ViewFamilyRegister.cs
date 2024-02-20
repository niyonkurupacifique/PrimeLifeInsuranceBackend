using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewFamilyRegister
{
    public string FullName { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public string? ProductCategory { get; set; }

    public string? PremiumFrequency { get; set; }

    public double RiskPremium { get; set; }

    public double? CommissionOnRiskPremium { get; set; }

    public double TotalPremium { get; set; }

    public DateOnly? CreationDate { get; set; }

    public DateOnly? RecordedDate { get; set; }

    public double? SumInsured { get; set; }

    public double? TotalSumInsured { get; set; }

    public string? ChannelType { get; set; }

    public string? ChannelName { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string? IdDocumentNumber { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? Gender { get; set; }

    public string? MartialStatus { get; set; }

    public string? Nationality { get; set; }

    public string? IdDocumentType { get; set; }

    public int PolicyTermYears { get; set; }
}
