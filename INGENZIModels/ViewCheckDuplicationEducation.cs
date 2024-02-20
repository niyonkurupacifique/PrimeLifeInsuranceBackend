using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewCheckDuplicationEducation
{
    public int IdRecord { get; set; }

    public string FullName { get; set; } = null!;

    public string? IdDocumentNumber { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public DateTime? DatePolicy { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? Differed { get; set; }

    public double? Premium { get; set; }

    public string StatusPolicy { get; set; } = null!;

    public string? UserName { get; set; }

    public string? Keyid { get; set; }

    public string? ProposalNumber { get; set; }

    public double? TotalPremium { get; set; }

    public double? RiskPremium { get; set; }

    public double? SavingsPremium { get; set; }

    public string? Product { get; set; }

    public string? SavingPolicy { get; set; }
}
