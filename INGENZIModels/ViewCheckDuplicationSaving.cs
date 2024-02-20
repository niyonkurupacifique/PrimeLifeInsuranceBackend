using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewCheckDuplicationSaving
{
    public int IdRecord { get; set; }

    public string FullName { get; set; } = null!;

    public string? IdDocumentNumber { get; set; }

    public string? PhoneNumber { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string PolicyNumberChild { get; set; } = null!;

    public DateTime RecordDate { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int Term { get; set; }

    public double Contribution { get; set; }

    public string UserName { get; set; } = null!;

    public string PolicyStatus { get; set; } = null!;

    public string? Keyid { get; set; }

    public string? ProposalNumber { get; set; }

    public double? Premium { get; set; }

    public double? RiskPremium { get; set; }

    public double? SavingsPremium { get; set; }

    public string? Product { get; set; }

    public string? RiskPolicyNumber { get; set; }
}
