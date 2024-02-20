using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewCheckDuplicationFamily
{
    public int? IdRecord { get; set; }

    public string? FullName { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string? CustomerCode { get; set; }

    public string? PolicyNumber { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public int? PolicyTermYears { get; set; }

    public double? RiskPremium { get; set; }

    public string PolicyStatus { get; set; } = null!;

    public string? UserName { get; set; }

    public string? Keyid { get; set; }

    public string? ProposalNumber { get; set; }

    public double? Premium { get; set; }

    public double? RiskPremium1 { get; set; }

    public double? SavingsPremium { get; set; }

    public string? Product { get; set; }

    public string? SavingPolicy { get; set; }
}
