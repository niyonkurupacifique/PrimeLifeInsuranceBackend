using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewFamilyPaymentStatementMax
{
    public string PolicyNumber { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public double? RiskPremium { get; set; }

    public double? AmountPaid { get; set; }

    public double? Balance { get; set; }

    public string? MaxPayDate { get; set; }

    public string? EffectiveDate { get; set; }

    public string? MaturityDate { get; set; }

    public string? ProductCategory { get; set; }

    public double? SumInsured { get; set; }

    public double Premium { get; set; }

    public string FullName { get; set; } = null!;

    public string? Salutation { get; set; }

    public string? Gender { get; set; }

    public string? DateOfBirth { get; set; }

    public string? MartialStatus { get; set; }

    public string? Nationality { get; set; }

    public string? IdDocumentNumber { get; set; }

    public bool? Surrendered { get; set; }

    public int? NumberOfInsuredLife { get; set; }

    public string? PremiumFrequency { get; set; }

    public string? PhoneNumber1 { get; set; }
}
