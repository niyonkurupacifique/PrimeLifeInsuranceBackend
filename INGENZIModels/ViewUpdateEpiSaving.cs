using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewUpdateEpiSaving
{
    public int IdRecord { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string? CustomerCode { get; set; }

    public string? ProductCategory { get; set; }

    public double SavingPremium { get; set; }

    public double Contribution { get; set; }

    public string? SavingPolicyNumber { get; set; }

    public string? Nid { get; set; }

    public string? Nidsavings { get; set; }

    public string FullName { get; set; } = null!;

    public string FullNamesSavings { get; set; } = null!;

    public string PolicyNumberChild { get; set; } = null!;

    public bool EndorsementMade { get; set; }

    public bool Cancelled { get; set; }

    public bool Surrendered { get; set; }

    public bool Suspended { get; set; }

    public bool? ClaimedEpi { get; set; }

    public bool? CancelledEpi { get; set; }

    public string? PolicyStatusEpi { get; set; }

    public string? SubProductType { get; set; }

    public string? SubPolicyNumber { get; set; }
}
